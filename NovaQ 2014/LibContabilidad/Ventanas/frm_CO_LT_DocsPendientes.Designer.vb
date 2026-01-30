<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_LT_DocsPendientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_LT_DocsPendientes))
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.dgv_docpen = New System.Windows.Forms.DataGridView()
        Me.Tool_Aceptar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.dgv_docpen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.Transparent
        Me.ToolS_Mantenimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Aceptar, Me.Tool_Salir, Me.tool_Ayuda2})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(814, 25)
        Me.ToolS_Mantenimiento.TabIndex = 9
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
        'dgv_docpen
        '
        Me.dgv_docpen.AllowUserToAddRows = False
        Me.dgv_docpen.AllowUserToDeleteRows = False
        Me.dgv_docpen.AllowUserToResizeColumns = False
        Me.dgv_docpen.AllowUserToResizeRows = False
        Me.dgv_docpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_docpen.Location = New System.Drawing.Point(12, 40)
        Me.dgv_docpen.Name = "dgv_docpen"
        Me.dgv_docpen.ReadOnly = True
        Me.dgv_docpen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_docpen.Size = New System.Drawing.Size(790, 264)
        Me.dgv_docpen.TabIndex = 10
        '
        'Tool_Aceptar
        '
        Me.Tool_Aceptar.Image = CType(resources.GetObject("Tool_Aceptar.Image"), System.Drawing.Image)
        Me.Tool_Aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Aceptar.Name = "Tool_Aceptar"
        Me.Tool_Aceptar.Size = New System.Drawing.Size(72, 22)
        Me.Tool_Aceptar.Text = "Aceptar"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = CType(resources.GetObject("Tool_Salir.Image"), System.Drawing.Image)
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(52, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'frm_CO_LT_DocsPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(814, 312)
        Me.Controls.Add(Me.dgv_docpen)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_CO_LT_DocsPendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos Pendientes"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.dgv_docpen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Private WithEvents dgv_docpen As System.Windows.Forms.DataGridView
End Class
