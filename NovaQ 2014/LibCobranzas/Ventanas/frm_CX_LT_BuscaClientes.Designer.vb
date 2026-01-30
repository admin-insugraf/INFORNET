<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_LT_BuscaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_LT_BuscaClientes))
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.CI_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CI_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.chk_empieza = New System.Windows.Forms.CheckBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CI_ID, Me.CI_NAME})
        Me.dgv_clientes.Location = New System.Drawing.Point(12, 79)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clientes.Size = New System.Drawing.Size(767, 303)
        Me.dgv_clientes.TabIndex = 0
        '
        'CI_ID
        '
        Me.CI_ID.DataPropertyName = "CI_ID"
        Me.CI_ID.HeaderText = "Ruc"
        Me.CI_ID.Name = "CI_ID"
        Me.CI_ID.ReadOnly = True
        Me.CI_ID.Width = 150
        '
        'CI_NAME
        '
        Me.CI_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CI_NAME.DataPropertyName = "CI_NAME"
        Me.CI_NAME.HeaderText = "Razon Social"
        Me.CI_NAME.Name = "CI_NAME"
        Me.CI_NAME.ReadOnly = True
        Me.CI_NAME.Width = 500
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(791, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = CType(resources.GetObject("Tool_salir.Image"), System.Drawing.Image)
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(12, 53)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(411, 20)
        Me.txt_filtro.TabIndex = 2
        '
        'chk_empieza
        '
        Me.chk_empieza.AutoSize = True
        Me.chk_empieza.Checked = True
        Me.chk_empieza.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_empieza.Location = New System.Drawing.Point(430, 56)
        Me.chk_empieza.Name = "chk_empieza"
        Me.chk_empieza.Size = New System.Drawing.Size(84, 17)
        Me.chk_empieza.TabIndex = 3
        Me.chk_empieza.Text = "Empieza por"
        Me.chk_empieza.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Image = Global.LibCobranzas.My.Resources.Resources.checkmark_26
        Me.btn_aceptar.Location = New System.Drawing.Point(720, 24)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(59, 49)
        Me.btn_aceptar.TabIndex = 4
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Filtrar por Razon Social"
        '
        'frm_CX_LT_BuscaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 394)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.chk_empieza)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_CX_LT_BuscaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Clientes"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents chk_empieza As System.Windows.Forms.CheckBox
    Friend WithEvents CI_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CI_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Private WithEvents Label8 As System.Windows.Forms.Label
End Class
