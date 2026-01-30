<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_LT_BuscaArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_LT_BuscaArticulos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.chk_empieza = New System.Windows.Forms.CheckBox()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.dgv_articulos = New System.Windows.Forms.DataGridView()
        Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_um = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(789, 25)
        Me.ToolStrip1.TabIndex = 2
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Filtrar por Descripcion"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Image = Global.LibCobranzas.My.Resources.Resources.checkmark_26
        Me.btn_aceptar.Location = New System.Drawing.Point(720, 19)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(59, 49)
        Me.btn_aceptar.TabIndex = 23
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'chk_empieza
        '
        Me.chk_empieza.AutoSize = True
        Me.chk_empieza.Checked = True
        Me.chk_empieza.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_empieza.Location = New System.Drawing.Point(430, 51)
        Me.chk_empieza.Name = "chk_empieza"
        Me.chk_empieza.Size = New System.Drawing.Size(84, 17)
        Me.chk_empieza.TabIndex = 22
        Me.chk_empieza.Text = "Empieza por"
        Me.chk_empieza.UseVisualStyleBackColor = True
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(12, 48)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(411, 20)
        Me.txt_filtro.TabIndex = 21
        '
        'dgv_articulos
        '
        Me.dgv_articulos.AllowUserToAddRows = False
        Me.dgv_articulos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_articulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cod, Me.col_des, Me.col_um})
        Me.dgv_articulos.Location = New System.Drawing.Point(12, 74)
        Me.dgv_articulos.Name = "dgv_articulos"
        Me.dgv_articulos.ReadOnly = True
        Me.dgv_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_articulos.Size = New System.Drawing.Size(767, 303)
        Me.dgv_articulos.TabIndex = 20
        '
        'col_cod
        '
        Me.col_cod.DataPropertyName = "COD"
        Me.col_cod.HeaderText = "Codigo"
        Me.col_cod.Name = "col_cod"
        Me.col_cod.ReadOnly = True
        '
        'col_des
        '
        Me.col_des.DataPropertyName = "DES"
        Me.col_des.HeaderText = "Descripcion"
        Me.col_des.Name = "col_des"
        Me.col_des.ReadOnly = True
        Me.col_des.Width = 400
        '
        'col_um
        '
        Me.col_um.DataPropertyName = "UM"
        Me.col_um.HeaderText = "Unid Med"
        Me.col_um.Name = "col_um"
        Me.col_um.ReadOnly = True
        '
        'frm_CX_LT_BuscaArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(789, 389)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.chk_empieza)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.dgv_articulos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_CX_LT_BuscaArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busca Articulos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents chk_empieza As System.Windows.Forms.CheckBox
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents dgv_articulos As System.Windows.Forms.DataGridView
    Friend WithEvents col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_um As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
