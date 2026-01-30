<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CX_MA_ConcepCob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CX_MA_ConcepCob))
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_lista = New System.Windows.Forms.DataGridView()
        Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tiptrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cmb_tip_trans = New System.Windows.Forms.ComboBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.chk_tarjeta = New System.Windows.Forms.CheckBox()
        Me.chk_aplica = New System.Windows.Forms.CheckBox()
        Me.chk_banco = New System.Windows.Forms.CheckBox()
        Me.chk_cheque = New System.Windows.Forms.CheckBox()
        Me.txt_cuenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_datos.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 36)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(594, 348)
        Me.tc_tipos.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_lista)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(586, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Registros"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_lista
        '
        Me.dgv_lista.AllowUserToAddRows = False
        Me.dgv_lista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_lista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cod, Me.col_des, Me.col_mon, Me.col_cuenta, Me.col_banco, Me.col_cheque, Me.col_apli, Me.col_tiptrans, Me.col_tar})
        Me.dgv_lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_lista.Location = New System.Drawing.Point(3, 3)
        Me.dgv_lista.MultiSelect = False
        Me.dgv_lista.Name = "dgv_lista"
        Me.dgv_lista.ReadOnly = True
        Me.dgv_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_lista.Size = New System.Drawing.Size(580, 316)
        Me.dgv_lista.TabIndex = 0
        '
        'col_cod
        '
        Me.col_cod.DataPropertyName = "RECEIVE_ID"
        Me.col_cod.HeaderText = "Codigo"
        Me.col_cod.Name = "col_cod"
        Me.col_cod.ReadOnly = True
        Me.col_cod.Width = 60
        '
        'col_des
        '
        Me.col_des.DataPropertyName = "DESCRIPTION"
        Me.col_des.HeaderText = "Descripcion"
        Me.col_des.Name = "col_des"
        Me.col_des.ReadOnly = True
        Me.col_des.Width = 300
        '
        'col_mon
        '
        Me.col_mon.DataPropertyName = "CURRENCY_ID"
        Me.col_mon.HeaderText = "Moneda"
        Me.col_mon.Name = "col_mon"
        Me.col_mon.ReadOnly = True
        '
        'col_cuenta
        '
        Me.col_cuenta.DataPropertyName = "ACCOUNT"
        Me.col_cuenta.HeaderText = "Cuenta Contable"
        Me.col_cuenta.Name = "col_cuenta"
        Me.col_cuenta.ReadOnly = True
        '
        'col_banco
        '
        Me.col_banco.DataPropertyName = "BANK_ID"
        Me.col_banco.HeaderText = "Banco"
        Me.col_banco.Name = "col_banco"
        Me.col_banco.ReadOnly = True
        Me.col_banco.Visible = False
        '
        'col_cheque
        '
        Me.col_cheque.DataPropertyName = "IS_CHECK_DIF"
        Me.col_cheque.HeaderText = "Cheque"
        Me.col_cheque.Name = "col_cheque"
        Me.col_cheque.ReadOnly = True
        Me.col_cheque.Visible = False
        '
        'col_apli
        '
        Me.col_apli.DataPropertyName = "IS_APPL"
        Me.col_apli.HeaderText = "Aplica"
        Me.col_apli.Name = "col_apli"
        Me.col_apli.ReadOnly = True
        Me.col_apli.Visible = False
        '
        'col_tiptrans
        '
        Me.col_tiptrans.DataPropertyName = "TRANS_TYPE"
        Me.col_tiptrans.HeaderText = "Transac"
        Me.col_tiptrans.Name = "col_tiptrans"
        Me.col_tiptrans.ReadOnly = True
        Me.col_tiptrans.Visible = False
        '
        'col_tar
        '
        Me.col_tar.DataPropertyName = "IS_CREDIT_CARD"
        Me.col_tar.HeaderText = "Tarjeta Cred"
        Me.col_tar.Name = "col_tar"
        Me.col_tar.ReadOnly = True
        Me.col_tar.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_datos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(586, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.PictureBox3)
        Me.gb_datos.Controls.Add(Me.cmb_tip_trans)
        Me.gb_datos.Controls.Add(Me.cmb_moneda)
        Me.gb_datos.Controls.Add(Me.chk_tarjeta)
        Me.gb_datos.Controls.Add(Me.chk_aplica)
        Me.gb_datos.Controls.Add(Me.chk_banco)
        Me.gb_datos.Controls.Add(Me.chk_cheque)
        Me.gb_datos.Controls.Add(Me.txt_cuenta)
        Me.gb_datos.Controls.Add(Me.Label5)
        Me.gb_datos.Controls.Add(Me.Label4)
        Me.gb_datos.Controls.Add(Me.Label3)
        Me.gb_datos.Controls.Add(Me.txt_des)
        Me.gb_datos.Controls.Add(Me.Label2)
        Me.gb_datos.Controls.Add(Me.txt_cod)
        Me.gb_datos.Controls.Add(Me.Label1)
        Me.gb_datos.Location = New System.Drawing.Point(12, 19)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(561, 287)
        Me.gb_datos.TabIndex = 3
        Me.gb_datos.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(90, 99)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox3.TabIndex = 121
        Me.PictureBox3.TabStop = False
        '
        'cmb_tip_trans
        '
        Me.cmb_tip_trans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tip_trans.FormattingEnabled = True
        Me.cmb_tip_trans.Items.AddRange(New Object() {"Efectivo", "Deposito", "Cheque", "Aplicacion Doc", "Factura Proveedor", "Cobro Cheque Dif.", "Tarjeta Credito", "Aplicacion de Saldo"})
        Me.cmb_tip_trans.Location = New System.Drawing.Point(90, 227)
        Me.cmb_tip_trans.Name = "cmb_tip_trans"
        Me.cmb_tip_trans.Size = New System.Drawing.Size(255, 21)
        Me.cmb_tip_trans.TabIndex = 5
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(90, 70)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(255, 21)
        Me.cmb_moneda.TabIndex = 5
        '
        'chk_tarjeta
        '
        Me.chk_tarjeta.AutoSize = True
        Me.chk_tarjeta.ForeColor = System.Drawing.Color.Navy
        Me.chk_tarjeta.Location = New System.Drawing.Point(236, 169)
        Me.chk_tarjeta.Name = "chk_tarjeta"
        Me.chk_tarjeta.Size = New System.Drawing.Size(110, 17)
        Me.chk_tarjeta.TabIndex = 4
        Me.chk_tarjeta.Text = "Tarjeta de Credito"
        Me.chk_tarjeta.UseVisualStyleBackColor = True
        '
        'chk_aplica
        '
        Me.chk_aplica.AutoSize = True
        Me.chk_aplica.ForeColor = System.Drawing.Color.Navy
        Me.chk_aplica.Location = New System.Drawing.Point(236, 146)
        Me.chk_aplica.Name = "chk_aplica"
        Me.chk_aplica.Size = New System.Drawing.Size(113, 17)
        Me.chk_aplica.TabIndex = 4
        Me.chk_aplica.Text = "Aplica Documento"
        Me.chk_aplica.UseVisualStyleBackColor = True
        '
        'chk_banco
        '
        Me.chk_banco.AutoSize = True
        Me.chk_banco.ForeColor = System.Drawing.Color.Navy
        Me.chk_banco.Location = New System.Drawing.Point(90, 146)
        Me.chk_banco.Name = "chk_banco"
        Me.chk_banco.Size = New System.Drawing.Size(57, 17)
        Me.chk_banco.TabIndex = 4
        Me.chk_banco.Text = "Banco"
        Me.chk_banco.UseVisualStyleBackColor = True
        '
        'chk_cheque
        '
        Me.chk_cheque.AutoSize = True
        Me.chk_cheque.ForeColor = System.Drawing.Color.Navy
        Me.chk_cheque.Location = New System.Drawing.Point(90, 169)
        Me.chk_cheque.Name = "chk_cheque"
        Me.chk_cheque.Size = New System.Drawing.Size(102, 17)
        Me.chk_cheque.TabIndex = 4
        Me.chk_cheque.Text = "Cheque Diferido"
        Me.chk_cheque.UseVisualStyleBackColor = True
        '
        'txt_cuenta
        '
        Me.txt_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cuenta.Location = New System.Drawing.Point(114, 99)
        Me.txt_cuenta.Name = "txt_cuenta"
        Me.txt_cuenta.ReadOnly = True
        Me.txt_cuenta.Size = New System.Drawing.Size(138, 20)
        Me.txt_cuenta.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(6, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Transaccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(0, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cuenta Contable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(38, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Moneda"
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(90, 44)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(256, 20)
        Me.txt_des.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(23, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripcion"
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(90, 18)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(109, 20)
        Me.txt_cod.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(45, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(618, 25)
        Me.ToolStrip1.TabIndex = 33
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
        Me.btn_eliminar.Visible = False
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
        'frm_CX_MA_ConcepCob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 405)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_tipos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CX_MA_ConcepCob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos de Cobranza"
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_lista As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_tarjeta As System.Windows.Forms.CheckBox
    Friend WithEvents chk_aplica As System.Windows.Forms.CheckBox
    Friend WithEvents chk_banco As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cheque As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tip_trans As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_apli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tiptrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
