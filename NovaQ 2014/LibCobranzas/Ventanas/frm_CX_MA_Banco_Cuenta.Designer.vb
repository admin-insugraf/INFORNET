<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_Banco_Cuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_Banco_Cuenta))
        Me.tc_bancos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_cuentas = New System.Windows.Forms.DataGridView()
        Me.col_banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_anexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnexo = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_doc = New System.Windows.Forms.ComboBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_num_cta = New System.Windows.Forms.TextBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tc_bancos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc_bancos
        '
        Me.tc_bancos.Controls.Add(Me.TabPage1)
        Me.tc_bancos.Controls.Add(Me.TabPage2)
        Me.tc_bancos.Location = New System.Drawing.Point(12, 33)
        Me.tc_bancos.Name = "tc_bancos"
        Me.tc_bancos.SelectedIndex = 0
        Me.tc_bancos.Size = New System.Drawing.Size(656, 276)
        Me.tc_bancos.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_cuentas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(648, 250)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Cuentas de Bancos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_cuentas
        '
        Me.dgv_cuentas.AllowUserToAddRows = False
        Me.dgv_cuentas.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_cuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_banco, Me.col_id, Me.col_des, Me.col_num, Me.col_mon, Me.col_tipo, Me.col_anexo})
        Me.dgv_cuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_cuentas.Location = New System.Drawing.Point(3, 3)
        Me.dgv_cuentas.Name = "dgv_cuentas"
        Me.dgv_cuentas.ReadOnly = True
        Me.dgv_cuentas.Size = New System.Drawing.Size(642, 244)
        Me.dgv_cuentas.TabIndex = 24
        '
        'col_banco
        '
        Me.col_banco.DataPropertyName = "BANK_ID"
        Me.col_banco.HeaderText = "Banco"
        Me.col_banco.Name = "col_banco"
        Me.col_banco.ReadOnly = True
        Me.col_banco.Visible = False
        '
        'col_id
        '
        Me.col_id.DataPropertyName = "ACCOUNT_BANK_ID"
        Me.col_id.FillWeight = 101.5228!
        Me.col_id.HeaderText = "Codigo"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        '
        'col_des
        '
        Me.col_des.DataPropertyName = "ACCOUNT_BANK_DES"
        Me.col_des.FillWeight = 98.47716!
        Me.col_des.HeaderText = "Descripcion"
        Me.col_des.Name = "col_des"
        Me.col_des.ReadOnly = True
        '
        'col_num
        '
        Me.col_num.DataPropertyName = "NUMBER_ACCOUNT"
        Me.col_num.HeaderText = "Num_Cuenta"
        Me.col_num.Name = "col_num"
        Me.col_num.ReadOnly = True
        Me.col_num.Visible = False
        '
        'col_mon
        '
        Me.col_mon.DataPropertyName = "CURRENCY_ID"
        Me.col_mon.HeaderText = "Moneda"
        Me.col_mon.Name = "col_mon"
        Me.col_mon.ReadOnly = True
        Me.col_mon.Visible = False
        '
        'col_tipo
        '
        Me.col_tipo.DataPropertyName = "TYPE_DOC"
        Me.col_tipo.HeaderText = "Tipo"
        Me.col_tipo.Name = "col_tipo"
        Me.col_tipo.ReadOnly = True
        Me.col_tipo.Visible = False
        '
        'col_anexo
        '
        Me.col_anexo.DataPropertyName = "TYPE_ANNEX"
        Me.col_anexo.HeaderText = "Anexo"
        Me.col_anexo.Name = "col_anexo"
        Me.col_anexo.ReadOnly = True
        Me.col_anexo.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(648, 250)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.PictureBox2)
        Me.gb_data.Controls.Add(Me.PictureBox1)
        Me.gb_data.Controls.Add(Me.Label5)
        Me.gb_data.Controls.Add(Me.txtAnexo)
        Me.gb_data.Controls.Add(Me.cmb_tipo_doc)
        Me.gb_data.Controls.Add(Me.cmb_moneda)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.Label4)
        Me.gb_data.Controls.Add(Me.Label2)
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Controls.Add(Me.Label6)
        Me.gb_data.Controls.Add(Me.txt_cod)
        Me.gb_data.Controls.Add(Me.txt_num_cta)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_data.Location = New System.Drawing.Point(3, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(642, 244)
        Me.gb_data.TabIndex = 6
        Me.gb_data.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(373, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 115
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(291, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de Anexo"
        '
        'txtAnexo
        '
        Me.txtAnexo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtAnexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnexo.Location = New System.Drawing.Point(399, 95)
        Me.txtAnexo.Name = "txtAnexo"
        Me.txtAnexo.Size = New System.Drawing.Size(95, 20)
        Me.txtAnexo.TabIndex = 7
        '
        'cmb_tipo_doc
        '
        Me.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_doc.FormattingEnabled = True
        Me.cmb_tipo_doc.Location = New System.Drawing.Point(110, 153)
        Me.cmb_tipo_doc.Name = "cmb_tipo_doc"
        Me.cmb_tipo_doc.Size = New System.Drawing.Size(206, 21)
        Me.cmb_tipo_doc.TabIndex = 6
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(110, 126)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(206, 21)
        Me.cmb_moneda.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(59, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(45, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo Doc."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(53, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Moneda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(30, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cuenta Cont."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(36, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripcion"
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(110, 43)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(115, 20)
        Me.txt_cod.TabIndex = 2
        '
        'txt_num_cta
        '
        Me.txt_num_cta.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_num_cta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_num_cta.Location = New System.Drawing.Point(137, 95)
        Me.txt_num_cta.Name = "txt_num_cta"
        Me.txt_num_cta.ReadOnly = True
        Me.txt_num_cta.Size = New System.Drawing.Size(125, 20)
        Me.txt_num_cta.TabIndex = 3
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(110, 69)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(385, 20)
        Me.txt_des.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(680, 25)
        Me.ToolStrip1.TabIndex = 196
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.btn_Nuevo.Text = "&Nuevo"
        '
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(73, 22)
        Me.btn_grabar.Text = "&Guardar"
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(81, 22)
        Me.btn_Editar.Text = "&Consultar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton7.Text = "&Salir"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(110, 96)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 116
        Me.PictureBox2.TabStop = False
        '
        'frm_CX_MA_Banco_Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(680, 327)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_bancos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_CX_MA_Banco_Cuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas de Banco"
        Me.tc_bancos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_bancos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_cuentas As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_data As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_num_cta As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAnexo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents col_banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_anexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
