<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_LT_ListaAsientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_LT_ListaAsientos))
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tool_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_editar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_anular = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_actualizar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_reaperturar = New System.Windows.Forms.ToolStripButton()
        Me.tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_Año = New System.Windows.Forms.DateTimePicker()
        Me.cmb_ope = New System.Windows.Forms.ComboBox()
        Me.cmb_sub = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cmb_meses = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dgv_asientos = New System.Windows.Forms.DataGridView()
        Me.toolStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.dgv_asientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.BackColor = System.Drawing.Color.White
        Me.toolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool_nuevo, Me.toolStripSeparator4, Me.tool_editar, Me.toolStripSeparator5, Me.tool_eliminar, Me.toolStripSeparator2, Me.tool_anular, Me.toolStripSeparator6, Me.tool_imprimir, Me.toolStripSeparator1, Me.tool_actualizar, Me.Tool_reaperturar, Me.tool_salir})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(873, 25)
        Me.toolStrip1.TabIndex = 8
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tool_nuevo
        '
        Me.tool_nuevo.Image = CType(resources.GetObject("tool_nuevo.Image"), System.Drawing.Image)
        Me.tool_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_nuevo.Name = "tool_nuevo"
        Me.tool_nuevo.Size = New System.Drawing.Size(62, 22)
        Me.tool_nuevo.Text = "&Nuevo"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tool_editar
        '
        Me.tool_editar.Image = CType(resources.GetObject("tool_editar.Image"), System.Drawing.Image)
        Me.tool_editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_editar.Name = "tool_editar"
        Me.tool_editar.Size = New System.Drawing.Size(139, 22)
        Me.tool_editar.Text = "&Consultar/Modificar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tool_eliminar
        '
        Me.tool_eliminar.Image = CType(resources.GetObject("tool_eliminar.Image"), System.Drawing.Image)
        Me.tool_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_eliminar.Name = "tool_eliminar"
        Me.tool_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.tool_eliminar.Text = "&Eliminar"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tool_anular
        '
        Me.tool_anular.Image = CType(resources.GetObject("tool_anular.Image"), System.Drawing.Image)
        Me.tool_anular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_anular.Name = "tool_anular"
        Me.tool_anular.Size = New System.Drawing.Size(64, 22)
        Me.tool_anular.Text = "&Anular"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tool_imprimir
        '
        Me.tool_imprimir.Image = CType(resources.GetObject("tool_imprimir.Image"), System.Drawing.Image)
        Me.tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_imprimir.Name = "tool_imprimir"
        Me.tool_imprimir.Size = New System.Drawing.Size(77, 22)
        Me.tool_imprimir.Text = "&Imprimir"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tool_actualizar
        '
        Me.tool_actualizar.Image = CType(resources.GetObject("tool_actualizar.Image"), System.Drawing.Image)
        Me.tool_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_actualizar.Name = "tool_actualizar"
        Me.tool_actualizar.Size = New System.Drawing.Size(133, 22)
        Me.tool_actualizar.Text = "&Mostrar/Refrescar"
        '
        'Tool_reaperturar
        '
        Me.Tool_reaperturar.Image = CType(resources.GetObject("Tool_reaperturar.Image"), System.Drawing.Image)
        Me.Tool_reaperturar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_reaperturar.Name = "Tool_reaperturar"
        Me.Tool_reaperturar.Size = New System.Drawing.Size(102, 22)
        Me.Tool_reaperturar.Text = "&Re-aperturar"
        '
        'tool_salir
        '
        Me.tool_salir.Image = CType(resources.GetObject("tool_salir.Image"), System.Drawing.Image)
        Me.tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_salir.Name = "tool_salir"
        Me.tool_salir.Size = New System.Drawing.Size(52, 22)
        Me.tool_salir.Text = "&Salir"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.dtp_Año)
        Me.groupBox1.Controls.Add(Me.cmb_ope)
        Me.groupBox1.Controls.Add(Me.cmb_sub)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.cmb_meses)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Location = New System.Drawing.Point(12, 28)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(849, 41)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(682, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Año"
        '
        'dtp_Año
        '
        Me.dtp_Año.CustomFormat = "yyyy"
        Me.dtp_Año.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Año.Location = New System.Drawing.Point(713, 14)
        Me.dtp_Año.Name = "dtp_Año"
        Me.dtp_Año.Size = New System.Drawing.Size(100, 20)
        Me.dtp_Año.TabIndex = 3
        '
        'cmb_ope
        '
        Me.cmb_ope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ope.FormattingEnabled = True
        Me.cmb_ope.Location = New System.Drawing.Point(68, 14)
        Me.cmb_ope.Name = "cmb_ope"
        Me.cmb_ope.Size = New System.Drawing.Size(139, 21)
        Me.cmb_ope.TabIndex = 0
        '
        'cmb_sub
        '
        Me.cmb_sub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sub.FormattingEnabled = True
        Me.cmb_sub.Location = New System.Drawing.Point(284, 13)
        Me.cmb_sub.Name = "cmb_sub"
        Me.cmb_sub.Size = New System.Drawing.Size(165, 21)
        Me.cmb_sub.TabIndex = 1
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(229, 17)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(51, 13)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Subdiario"
        '
        'cmb_meses
        '
        Me.cmb_meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_meses.FormattingEnabled = True
        Me.cmb_meses.Location = New System.Drawing.Point(519, 14)
        Me.cmb_meses.Name = "cmb_meses"
        Me.cmb_meses.Size = New System.Drawing.Size(128, 21)
        Me.cmb_meses.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Navy
        Me.label1.Location = New System.Drawing.Point(486, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(27, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Mes"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(6, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Operacion"
        '
        'dgv_asientos
        '
        Me.dgv_asientos.AllowUserToAddRows = False
        Me.dgv_asientos.AllowUserToDeleteRows = False
        Me.dgv_asientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_asientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_asientos.Location = New System.Drawing.Point(12, 75)
        Me.dgv_asientos.Name = "dgv_asientos"
        Me.dgv_asientos.ReadOnly = True
        Me.dgv_asientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_asientos.Size = New System.Drawing.Size(849, 544)
        Me.dgv_asientos.TabIndex = 4
        '
        'frm_CO_LT_ListaAsientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(873, 631)
        Me.Controls.Add(Me.dgv_asientos)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.toolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_LT_ListaAsientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asientos Contables"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dgv_asientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tool_nuevo As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tool_editar As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tool_eliminar As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tool_anular As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tool_imprimir As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tool_salir As System.Windows.Forms.ToolStripButton
    Private WithEvents tool_actualizar As System.Windows.Forms.ToolStripButton
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents cmb_ope As System.Windows.Forms.ComboBox
    Private WithEvents cmb_sub As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents cmb_meses As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_asientos As System.Windows.Forms.DataGridView
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_Año As System.Windows.Forms.DateTimePicker
    Private WithEvents Tool_reaperturar As System.Windows.Forms.ToolStripButton
End Class
