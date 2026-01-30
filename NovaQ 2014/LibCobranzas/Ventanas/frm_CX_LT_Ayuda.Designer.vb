<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_LT_Ayuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_LT_Ayuda))
        Me.dgv_data = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.chk_empieza = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_data
        '
        Me.dgv_data.AllowUserToAddRows = False
        Me.dgv_data.AllowUserToDeleteRows = False
        Me.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data.Location = New System.Drawing.Point(12, 86)
        Me.dgv_data.MultiSelect = False
        Me.dgv_data.Name = "dgv_data"
        Me.dgv_data.ReadOnly = True
        Me.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_data.Size = New System.Drawing.Size(737, 303)
        Me.dgv_data.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(761, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = CType(resources.GetObject("Tool_Salir.Image"), System.Drawing.Image)
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
        'txt_filtro
        '
        Me.txt_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.Location = New System.Drawing.Point(12, 60)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(737, 22)
        Me.txt_filtro.TabIndex = 3
        '
        'chk_empieza
        '
        Me.chk_empieza.AutoSize = True
        Me.chk_empieza.Checked = True
        Me.chk_empieza.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_empieza.Location = New System.Drawing.Point(12, 37)
        Me.chk_empieza.Name = "chk_empieza"
        Me.chk_empieza.Size = New System.Drawing.Size(96, 17)
        Me.chk_empieza.TabIndex = 4
        Me.chk_empieza.Text = "Empieza con..."
        Me.chk_empieza.UseVisualStyleBackColor = True
        '
        'frm_CX_LT_Ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(761, 401)
        Me.Controls.Add(Me.chk_empieza)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_CX_LT_Ayuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_CX_LT_Ayuda"
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_data As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents chk_empieza As System.Windows.Forms.CheckBox
End Class
