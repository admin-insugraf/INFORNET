<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_RP_Depre_x_Activo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_RP_Depre_x_Activo))
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_cod_activo = New System.Windows.Forms.TextBox()
        Me.btn_procesar = New System.Windows.Forms.Button()
        Me.txt_valorResidual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Tipo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_costo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_vidaUtil = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_activo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_listado = New System.Windows.Forms.DataGridView()
        Me.col_periodos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_depre_anual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_depre_acu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_libros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.LightGray
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.tool_Ayuda2, Me.Tool_Exportar, Me.ToolStripSeparator7, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(769, 25)
        Me.ToolS_Mantenimiento.TabIndex = 10
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
        Me.Tool_Exportar.Size = New System.Drawing.Size(111, 22)
        Me.Tool_Exportar.Text = "Hoja de Calculo"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_cod_activo)
        Me.GroupBox1.Controls.Add(Me.btn_procesar)
        Me.GroupBox1.Controls.Add(Me.txt_valorResidual)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Tipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_costo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_vidaUtil)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_activo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 100)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(557, 17)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(27, 23)
        Me.btn_buscar.TabIndex = 9
        Me.btn_buscar.Text = "..."
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_cod_activo
        '
        Me.txt_cod_activo.Location = New System.Drawing.Point(108, 19)
        Me.txt_cod_activo.Name = "txt_cod_activo"
        Me.txt_cod_activo.Size = New System.Drawing.Size(92, 20)
        Me.txt_cod_activo.TabIndex = 0
        '
        'btn_procesar
        '
        Me.btn_procesar.Location = New System.Drawing.Point(650, 68)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(89, 23)
        Me.btn_procesar.TabIndex = 6
        Me.btn_procesar.Text = "Procesar"
        Me.btn_procesar.UseVisualStyleBackColor = True
        '
        'txt_valorResidual
        '
        Me.txt_valorResidual.Location = New System.Drawing.Point(327, 71)
        Me.txt_valorResidual.Name = "txt_valorResidual"
        Me.txt_valorResidual.Size = New System.Drawing.Size(228, 20)
        Me.txt_valorResidual.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Valor Residual"
        '
        'txt_Tipo
        '
        Me.txt_Tipo.Location = New System.Drawing.Point(327, 45)
        Me.txt_Tipo.Name = "txt_Tipo"
        Me.txt_Tipo.Size = New System.Drawing.Size(228, 20)
        Me.txt_Tipo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tipo de Depreciacion"
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(108, 71)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(63, 20)
        Me.txt_costo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Costo del Activo"
        '
        'txt_vidaUtil
        '
        Me.txt_vidaUtil.Location = New System.Drawing.Point(108, 45)
        Me.txt_vidaUtil.Name = "txt_vidaUtil"
        Me.txt_vidaUtil.Size = New System.Drawing.Size(63, 20)
        Me.txt_vidaUtil.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vida Util"
        '
        'txt_activo
        '
        Me.txt_activo.Location = New System.Drawing.Point(200, 19)
        Me.txt_activo.Name = "txt_activo"
        Me.txt_activo.Size = New System.Drawing.Size(355, 20)
        Me.txt_activo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Activo Fijo"
        '
        'dgv_listado
        '
        Me.dgv_listado.AllowUserToAddRows = False
        Me.dgv_listado.AllowUserToDeleteRows = False
        Me.dgv_listado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_periodos, Me.col_concepto, Me.col_depre_anual, Me.col_depre_acu, Me.col_libros})
        Me.dgv_listado.Location = New System.Drawing.Point(12, 144)
        Me.dgv_listado.Name = "dgv_listado"
        Me.dgv_listado.ReadOnly = True
        Me.dgv_listado.Size = New System.Drawing.Size(745, 303)
        Me.dgv_listado.TabIndex = 12
        '
        'col_periodos
        '
        Me.col_periodos.HeaderText = "Nº de Periodos"
        Me.col_periodos.Name = "col_periodos"
        Me.col_periodos.ReadOnly = True
        Me.col_periodos.Width = 70
        '
        'col_concepto
        '
        Me.col_concepto.HeaderText = "Concepto"
        Me.col_concepto.Name = "col_concepto"
        Me.col_concepto.ReadOnly = True
        Me.col_concepto.Width = 200
        '
        'col_depre_anual
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.col_depre_anual.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_depre_anual.HeaderText = "Depreciacion Anual"
        Me.col_depre_anual.Name = "col_depre_anual"
        Me.col_depre_anual.ReadOnly = True
        '
        'col_depre_acu
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.col_depre_acu.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_depre_acu.HeaderText = "Depreciacion Acumulada"
        Me.col_depre_acu.Name = "col_depre_acu"
        Me.col_depre_acu.ReadOnly = True
        '
        'col_libros
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.col_libros.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_libros.HeaderText = "Importe en Libros"
        Me.col_libros.Name = "col_libros"
        Me.col_libros.ReadOnly = True
        '
        'frm_AF_RP_Depre_x_Activo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(769, 459)
        Me.Controls.Add(Me.dgv_listado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_AF_RP_Depre_x_Activo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depreciacion  por Activo"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_valorResidual As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Tipo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_costo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_vidaUtil As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_activo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
    Friend WithEvents dgv_listado As System.Windows.Forms.DataGridView
    Friend WithEvents txt_cod_activo As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents col_periodos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_depre_anual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_depre_acu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_libros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tool_Exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
