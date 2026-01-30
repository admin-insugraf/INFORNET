<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_RP_Lis_Activos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_RP_Lis_Activos))
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgv_listado = New System.Windows.Forms.DataGridView()
        Me.btn_procesar = New System.Windows.Forms.Button()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.LightGray
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.tool_Ayuda2, Me.Tool_Exportar, Me.ToolStripSeparator7, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(778, 25)
        Me.ToolS_Mantenimiento.TabIndex = 11
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'Tool_Exportar
        '
        Me.Tool_Exportar.Image = Global.LibActivo.My.Resources.Resources._16__Doc_excel_
        Me.Tool_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Exportar.Name = "Tool_Exportar"
        Me.Tool_Exportar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Exportar.Text = "Exportar"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'dgv_listado
        '
        Me.dgv_listado.AllowUserToAddRows = False
        Me.dgv_listado.AllowUserToDeleteRows = False
        Me.dgv_listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listado.Location = New System.Drawing.Point(12, 81)
        Me.dgv_listado.Name = "dgv_listado"
        Me.dgv_listado.ReadOnly = True
        Me.dgv_listado.Size = New System.Drawing.Size(754, 303)
        Me.dgv_listado.TabIndex = 12
        '
        'btn_procesar
        '
        Me.btn_procesar.Image = Global.LibActivo.My.Resources.Resources._16__Configure_
        Me.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_procesar.Location = New System.Drawing.Point(12, 43)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(107, 32)
        Me.btn_procesar.TabIndex = 13
        Me.btn_procesar.Text = "Procesar"
        Me.btn_procesar.UseVisualStyleBackColor = True
        '
        'frm_AF_RP_Lis_Activos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(778, 396)
        Me.Controls.Add(Me.btn_procesar)
        Me.Controls.Add(Me.dgv_listado)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_RP_Lis_Activos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Activos"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgv_listado As System.Windows.Forms.DataGridView
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
End Class
