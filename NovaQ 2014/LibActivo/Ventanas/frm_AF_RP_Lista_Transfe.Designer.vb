<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_RP_Lista_Transfe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_RP_Lista_Transfe))
        Me.dgv_listado = New System.Windows.Forms.DataGridView()
        Me.NUM_FOLIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORIGEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESPONSABLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_procesar = New System.Windows.Forms.Button()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_listado
        '
        Me.dgv_listado.AllowUserToAddRows = False
        Me.dgv_listado.AllowUserToDeleteRows = False
        Me.dgv_listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUM_FOLIO, Me.ACTIVO, Me.FECHA, Me.ORIGEN, Me.DESTINO, Me.RESPONSABLE, Me.OBSERVACIONES})
        Me.dgv_listado.Location = New System.Drawing.Point(12, 84)
        Me.dgv_listado.Name = "dgv_listado"
        Me.dgv_listado.ReadOnly = True
        Me.dgv_listado.Size = New System.Drawing.Size(732, 221)
        Me.dgv_listado.TabIndex = 0
        '
        'NUM_FOLIO
        '
        Me.NUM_FOLIO.DataPropertyName = "NUM_FOLIO"
        Me.NUM_FOLIO.HeaderText = "NUM_FOLIO"
        Me.NUM_FOLIO.Name = "NUM_FOLIO"
        Me.NUM_FOLIO.ReadOnly = True
        Me.NUM_FOLIO.Width = 94
        '
        'ACTIVO
        '
        Me.ACTIVO.DataPropertyName = "ACTIVO"
        Me.ACTIVO.HeaderText = "ACTIVO"
        Me.ACTIVO.Name = "ACTIVO"
        Me.ACTIVO.ReadOnly = True
        Me.ACTIVO.Width = 71
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Width = 67
        '
        'ORIGEN
        '
        Me.ORIGEN.DataPropertyName = "ORIGEN"
        Me.ORIGEN.HeaderText = "ORIGEN"
        Me.ORIGEN.Name = "ORIGEN"
        Me.ORIGEN.ReadOnly = True
        Me.ORIGEN.Width = 74
        '
        'DESTINO
        '
        Me.DESTINO.DataPropertyName = "DESTINO"
        Me.DESTINO.HeaderText = "DESTINO"
        Me.DESTINO.Name = "DESTINO"
        Me.DESTINO.ReadOnly = True
        Me.DESTINO.Width = 80
        '
        'RESPONSABLE
        '
        Me.RESPONSABLE.DataPropertyName = "RESPONSABLE"
        Me.RESPONSABLE.HeaderText = "RESPONSABLE"
        Me.RESPONSABLE.Name = "RESPONSABLE"
        Me.RESPONSABLE.ReadOnly = True
        Me.RESPONSABLE.Width = 111
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.DataPropertyName = "OBSERVACIONES"
        Me.OBSERVACIONES.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONES.Name = "OBSERVACIONES"
        Me.OBSERVACIONES.ReadOnly = True
        Me.OBSERVACIONES.Width = 123
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.LightGray
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool_Ayuda2, Me.Tool_exportar, Me.ToolStripSeparator7, Me.Tool_Salir, Me.ToolStripSeparator3})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(756, 25)
        Me.ToolS_Mantenimiento.TabIndex = 10
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
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
        'Tool_exportar
        '
        Me.Tool_exportar.Image = Global.LibActivo.My.Resources.Resources._16__Doc_excel_
        Me.Tool_exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_exportar.Name = "Tool_exportar"
        Me.Tool_exportar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_exportar.Text = "Exportar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.LibActivo.My.Resources.Resources._16__Exit_
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_procesar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 50)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'btn_procesar
        '
        Me.btn_procesar.Image = Global.LibActivo.My.Resources.Resources._16__Configure_
        Me.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_procesar.Location = New System.Drawing.Point(6, 14)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(107, 28)
        Me.btn_procesar.TabIndex = 13
        Me.btn_procesar.Text = "Procesar"
        Me.btn_procesar.UseVisualStyleBackColor = True
        '
        'frm_AF_RP_Lista_Transfe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(756, 327)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.dgv_listado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_RP_Lista_Transfe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Transferencias"
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_listado As System.Windows.Forms.DataGridView
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
    Friend WithEvents NUM_FOLIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORIGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTINO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESPONSABLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONES As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
