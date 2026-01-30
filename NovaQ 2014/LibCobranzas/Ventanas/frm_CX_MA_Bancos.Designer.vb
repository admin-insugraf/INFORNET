<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_Bancos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_Bancos))
        Me.dgv_bancos = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cobranza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc_bancos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipoCobranzas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.btn_cta_cte = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgv_bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_bancos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_bancos
        '
        Me.dgv_bancos.AllowUserToAddRows = False
        Me.dgv_bancos.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_bancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_bancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_bancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_des, Me.col_cobranza})
        Me.dgv_bancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_bancos.Location = New System.Drawing.Point(3, 3)
        Me.dgv_bancos.Name = "dgv_bancos"
        Me.dgv_bancos.ReadOnly = True
        Me.dgv_bancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_bancos.Size = New System.Drawing.Size(460, 244)
        Me.dgv_bancos.TabIndex = 24
        '
        'col_id
        '
        Me.col_id.DataPropertyName = "ID"
        Me.col_id.HeaderText = "Codigo"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        '
        'col_des
        '
        Me.col_des.DataPropertyName = "NAME"
        Me.col_des.HeaderText = "Descripcion"
        Me.col_des.Name = "col_des"
        Me.col_des.ReadOnly = True
        '
        'col_cobranza
        '
        Me.col_cobranza.DataPropertyName = "RECEIVE_ID"
        Me.col_cobranza.HeaderText = "Cobranza"
        Me.col_cobranza.Name = "col_cobranza"
        Me.col_cobranza.ReadOnly = True
        Me.col_cobranza.Visible = False
        '
        'tc_bancos
        '
        Me.tc_bancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_bancos.Controls.Add(Me.TabPage1)
        Me.tc_bancos.Controls.Add(Me.TabPage2)
        Me.tc_bancos.Location = New System.Drawing.Point(12, 37)
        Me.tc_bancos.Name = "tc_bancos"
        Me.tc_bancos.SelectedIndex = 0
        Me.tc_bancos.Size = New System.Drawing.Size(474, 276)
        Me.tc_bancos.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_bancos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(466, 250)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Bancos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(466, 250)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.PictureBox1)
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Controls.Add(Me.txtTipoCobranzas)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.Label6)
        Me.gb_data.Controls.Add(Me.txt_cod)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_data.ForeColor = System.Drawing.Color.Navy
        Me.gb_data.Location = New System.Drawing.Point(3, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(460, 244)
        Me.gb_data.TabIndex = 6
        Me.gb_data.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(110, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(15, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tipo de Cobranza"
        '
        'txtTipoCobranzas
        '
        Me.txtTipoCobranzas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCobranzas.Location = New System.Drawing.Point(131, 106)
        Me.txtTipoCobranzas.Name = "txtTipoCobranzas"
        Me.txtTipoCobranzas.Size = New System.Drawing.Size(79, 20)
        Me.txtTipoCobranzas.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(66, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(44, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripcion"
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(110, 46)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod.TabIndex = 2
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(111, 77)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(334, 20)
        Me.txt_des.TabIndex = 3
        '
        'btn_cta_cte
        '
        Me.btn_cta_cte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cta_cte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cta_cte.ForeColor = System.Drawing.Color.Blue
        Me.btn_cta_cte.Image = CType(resources.GetObject("btn_cta_cte.Image"), System.Drawing.Image)
        Me.btn_cta_cte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cta_cte.Location = New System.Drawing.Point(12, 314)
        Me.btn_cta_cte.Name = "btn_cta_cte"
        Me.btn_cta_cte.Size = New System.Drawing.Size(137, 29)
        Me.btn_cta_cte.TabIndex = 26
        Me.btn_cta_cte.Text = "Cuentas Corrientes"
        Me.btn_cta_cte.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(494, 25)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nuevo.Text = "&Nuevo"
        '
        'btn_grabar
        '
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_Editar
        '
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(79, 22)
        Me.btn_Editar.Text = "&Modificar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton6.Text = "&Salir"
        '
        'frm_CX_MA_Bancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(494, 346)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_cta_cte)
        Me.Controls.Add(Me.tc_bancos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CX_MA_Bancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bancos de Cobranza"
        CType(Me.dgv_bancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_bancos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_bancos As System.Windows.Forms.DataGridView
    Friend WithEvents tc_bancos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents gb_data As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cta_cte As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCobranzas As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cobranza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
End Class
