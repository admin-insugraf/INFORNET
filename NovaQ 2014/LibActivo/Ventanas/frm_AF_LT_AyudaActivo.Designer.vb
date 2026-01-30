<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_LT_AyudaActivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_LT_AyudaActivo))
        Me.dgv_ayuda = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_aceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_comienza = New System.Windows.Forms.CheckBox()
        Me.AC_IDACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AC_ACTIVO_DES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AC_CODIGO_ALT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_ayuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_ayuda
        '
        Me.dgv_ayuda.AllowUserToAddRows = False
        Me.dgv_ayuda.AllowUserToDeleteRows = False
        Me.dgv_ayuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ayuda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AC_IDACTIVO, Me.AC_ACTIVO_DES, Me.AC_CODIGO_ALT})
        Me.dgv_ayuda.Location = New System.Drawing.Point(12, 82)
        Me.dgv_ayuda.Name = "dgv_ayuda"
        Me.dgv_ayuda.ReadOnly = True
        Me.dgv_ayuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ayuda.Size = New System.Drawing.Size(607, 269)
        Me.dgv_ayuda.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_aceptar, Me.ToolStripSeparator1, Me.Tool_salir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(631, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_aceptar
        '
        Me.Tool_aceptar.Image = Global.LibActivo.My.Resources.Resources._16__Ok_
        Me.Tool_aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_aceptar.Name = "Tool_aceptar"
        Me.Tool_aceptar.Size = New System.Drawing.Size(68, 22)
        Me.Tool_aceptar.Text = "Aceptar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.LibActivo.My.Resources.Resources._16__Exit_
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(89, 56)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(530, 20)
        Me.txt_filtro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descripcion"
        '
        'chk_comienza
        '
        Me.chk_comienza.AutoSize = True
        Me.chk_comienza.Checked = True
        Me.chk_comienza.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_comienza.ForeColor = System.Drawing.Color.Navy
        Me.chk_comienza.Location = New System.Drawing.Point(529, 33)
        Me.chk_comienza.Name = "chk_comienza"
        Me.chk_comienza.Size = New System.Drawing.Size(90, 17)
        Me.chk_comienza.TabIndex = 4
        Me.chk_comienza.Text = "Comienza por"
        Me.chk_comienza.UseVisualStyleBackColor = True
        '
        'AC_IDACTIVO
        '
        Me.AC_IDACTIVO.DataPropertyName = "AC_IDACTIVO"
        Me.AC_IDACTIVO.HeaderText = "Codigo"
        Me.AC_IDACTIVO.Name = "AC_IDACTIVO"
        Me.AC_IDACTIVO.ReadOnly = True
        '
        'AC_ACTIVO_DES
        '
        Me.AC_ACTIVO_DES.DataPropertyName = "AC_ACTIVO_DES"
        Me.AC_ACTIVO_DES.HeaderText = "Descripcion"
        Me.AC_ACTIVO_DES.Name = "AC_ACTIVO_DES"
        Me.AC_ACTIVO_DES.ReadOnly = True
        Me.AC_ACTIVO_DES.Width = 400
        '
        'AC_CODIGO_ALT
        '
        Me.AC_CODIGO_ALT.DataPropertyName = "AC_CODIGO_ALT"
        Me.AC_CODIGO_ALT.HeaderText = "Cod. Alter."
        Me.AC_CODIGO_ALT.Name = "AC_CODIGO_ALT"
        Me.AC_CODIGO_ALT.ReadOnly = True
        Me.AC_CODIGO_ALT.Visible = False
        Me.AC_CODIGO_ALT.Width = 50
        '
        'frm_AF_LT_AyudaActivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 363)
        Me.Controls.Add(Me.chk_comienza)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_ayuda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_AF_LT_AyudaActivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Activos"
        CType(Me.dgv_ayuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_ayuda As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_comienza As System.Windows.Forms.CheckBox
    Friend WithEvents AC_IDACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AC_ACTIVO_DES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AC_CODIGO_ALT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
