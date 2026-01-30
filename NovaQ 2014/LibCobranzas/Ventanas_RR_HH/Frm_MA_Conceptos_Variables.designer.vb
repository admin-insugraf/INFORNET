<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MA_Conceptos_Variables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_MA_Conceptos_Variables))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_transacciones = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_data = New System.Windows.Forms.GroupBox()
        Me.gbCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.cbo_debe_haber = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcompra = New System.Windows.Forms.Label()
        Me.txtcuentaProd = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtcuentaVta = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtcuentaAdm = New System.Windows.Forms.TextBox()
        Me.chk_afecto_afp = New System.Windows.Forms.CheckBox()
        Me.chk_afecto_essalud = New System.Windows.Forms.CheckBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_detalla_anexo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ruc_anexo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.tc_tipos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_transacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb_data.SuspendLayout()
        Me.gbCaracteristicas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_Editar, Me.btn_eliminar, Me.btn_grabar, Me.btn_cancelar, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(527, 25)
        Me.ToolStrip1.TabIndex = 204
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
        'btn_grabar
        '
        Me.btn_grabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grabar.Image = CType(resources.GetObject("btn_grabar.Image"), System.Drawing.Image)
        Me.btn_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(73, 22)
        Me.btn_grabar.Text = "&Guardar"
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
        'ToolStripButton8
        '
        Me.ToolStripButton8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton8.Text = "&Salir"
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 35)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(503, 454)
        Me.tc_tipos.TabIndex = 203
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgv_transacciones)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(495, 327)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Conceptos"
        '
        'dgv_transacciones
        '
        Me.dgv_transacciones.AllowUserToAddRows = False
        Me.dgv_transacciones.AllowUserToDeleteRows = False
        Me.dgv_transacciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_transacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_transacciones.Location = New System.Drawing.Point(21, 58)
        Me.dgv_transacciones.Name = "dgv_transacciones"
        Me.dgv_transacciones.ReadOnly = True
        Me.dgv_transacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_transacciones.Size = New System.Drawing.Size(450, 243)
        Me.dgv_transacciones.TabIndex = 125
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(21, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 45)
        Me.GroupBox3.TabIndex = 124
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(437, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCantidad.Location = New System.Drawing.Point(22, 304)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 123
        Me.lblCantidad.Text = "."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_data)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(495, 428)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_data
        '
        Me.gb_data.BackColor = System.Drawing.Color.White
        Me.gb_data.Controls.Add(Me.gbCaracteristicas)
        Me.gb_data.Controls.Add(Me.cmb_tipo)
        Me.gb_data.Controls.Add(Me.Label1)
        Me.gb_data.Controls.Add(Me.Label3)
        Me.gb_data.Controls.Add(Me.Label6)
        Me.gb_data.Controls.Add(Me.txt_cod)
        Me.gb_data.Controls.Add(Me.txt_des)
        Me.gb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_data.Location = New System.Drawing.Point(3, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(489, 422)
        Me.gb_data.TabIndex = 6
        Me.gb_data.TabStop = False
        '
        'gbCaracteristicas
        '
        Me.gbCaracteristicas.Controls.Add(Me.GroupBox1)
        Me.gbCaracteristicas.Controls.Add(Me.cbo_debe_haber)
        Me.gbCaracteristicas.Controls.Add(Me.Label2)
        Me.gbCaracteristicas.Controls.Add(Me.lblcompra)
        Me.gbCaracteristicas.Controls.Add(Me.txtcuentaProd)
        Me.gbCaracteristicas.Controls.Add(Me.Label30)
        Me.gbCaracteristicas.Controls.Add(Me.txtcuentaVta)
        Me.gbCaracteristicas.Controls.Add(Me.Label29)
        Me.gbCaracteristicas.Controls.Add(Me.txtcuentaAdm)
        Me.gbCaracteristicas.Controls.Add(Me.chk_afecto_afp)
        Me.gbCaracteristicas.Controls.Add(Me.chk_afecto_essalud)
        Me.gbCaracteristicas.ForeColor = System.Drawing.Color.Navy
        Me.gbCaracteristicas.Location = New System.Drawing.Point(6, 100)
        Me.gbCaracteristicas.Name = "gbCaracteristicas"
        Me.gbCaracteristicas.Size = New System.Drawing.Size(477, 316)
        Me.gbCaracteristicas.TabIndex = 17
        Me.gbCaracteristicas.TabStop = False
        Me.gbCaracteristicas.Text = "Caracteristicas"
        '
        'cbo_debe_haber
        '
        Me.cbo_debe_haber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_debe_haber.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_debe_haber.FormattingEnabled = True
        Me.cbo_debe_haber.Items.AddRange(New Object() {"Debe", "Haber"})
        Me.cbo_debe_haber.Location = New System.Drawing.Point(102, 173)
        Me.cbo_debe_haber.Name = "cbo_debe_haber"
        Me.cbo_debe_haber.Size = New System.Drawing.Size(97, 21)
        Me.cbo_debe_haber.TabIndex = 199
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(27, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Debe/Haber"
        '
        'lblcompra
        '
        Me.lblcompra.AutoSize = True
        Me.lblcompra.ForeColor = System.Drawing.Color.Navy
        Me.lblcompra.Location = New System.Drawing.Point(27, 151)
        Me.lblcompra.Name = "lblcompra"
        Me.lblcompra.Size = New System.Drawing.Size(66, 13)
        Me.lblcompra.TabIndex = 197
        Me.lblcompra.Text = "Cuenta Prod"
        '
        'txtcuentaProd
        '
        Me.txtcuentaProd.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcuentaProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaProd.Location = New System.Drawing.Point(102, 148)
        Me.txtcuentaProd.Name = "txtcuentaProd"
        Me.txtcuentaProd.ReadOnly = True
        Me.txtcuentaProd.Size = New System.Drawing.Size(97, 20)
        Me.txtcuentaProd.TabIndex = 195
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(27, 125)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 13)
        Me.Label30.TabIndex = 196
        Me.Label30.Text = "Cuenta Vta"
        '
        'txtcuentaVta
        '
        Me.txtcuentaVta.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcuentaVta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaVta.Location = New System.Drawing.Point(102, 122)
        Me.txtcuentaVta.Name = "txtcuentaVta"
        Me.txtcuentaVta.ReadOnly = True
        Me.txtcuentaVta.Size = New System.Drawing.Size(97, 20)
        Me.txtcuentaVta.TabIndex = 194
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(27, 97)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 13)
        Me.Label29.TabIndex = 193
        Me.Label29.Text = "Cuenta Adm"
        '
        'txtcuentaAdm
        '
        Me.txtcuentaAdm.BackColor = System.Drawing.Color.Aquamarine
        Me.txtcuentaAdm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcuentaAdm.Location = New System.Drawing.Point(102, 95)
        Me.txtcuentaAdm.Name = "txtcuentaAdm"
        Me.txtcuentaAdm.ReadOnly = True
        Me.txtcuentaAdm.Size = New System.Drawing.Size(97, 20)
        Me.txtcuentaAdm.TabIndex = 192
        '
        'chk_afecto_afp
        '
        Me.chk_afecto_afp.AutoSize = True
        Me.chk_afecto_afp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_afecto_afp.ForeColor = System.Drawing.Color.Navy
        Me.chk_afecto_afp.Location = New System.Drawing.Point(27, 57)
        Me.chk_afecto_afp.Name = "chk_afecto_afp"
        Me.chk_afecto_afp.Size = New System.Drawing.Size(89, 17)
        Me.chk_afecto_afp.TabIndex = 16
        Me.chk_afecto_afp.Text = "Afecto a AFP"
        Me.chk_afecto_afp.UseVisualStyleBackColor = True
        '
        'chk_afecto_essalud
        '
        Me.chk_afecto_essalud.AutoSize = True
        Me.chk_afecto_essalud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_afecto_essalud.ForeColor = System.Drawing.Color.Navy
        Me.chk_afecto_essalud.Location = New System.Drawing.Point(27, 28)
        Me.chk_afecto_essalud.Name = "chk_afecto_essalud"
        Me.chk_afecto_essalud.Size = New System.Drawing.Size(119, 17)
        Me.chk_afecto_essalud.TabIndex = 13
        Me.chk_afecto_essalud.Text = "Afecto a ESSALUD"
        Me.chk_afecto_essalud.UseVisualStyleBackColor = True
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(10, 34)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(152, 21)
        Me.cmb_tipo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(59, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripción"
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(10, 74)
        Me.txt_cod.MaxLength = 2
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(43, 20)
        Me.txt_cod.TabIndex = 1
        Me.txt_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(57, 74)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(426, 20)
        Me.txt_des.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_ruc_anexo)
        Me.GroupBox1.Controls.Add(Me.chk_detalla_anexo)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(27, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 100)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Al generar el asiento de planilla"
        '
        'chk_detalla_anexo
        '
        Me.chk_detalla_anexo.AutoSize = True
        Me.chk_detalla_anexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chk_detalla_anexo.ForeColor = System.Drawing.Color.Navy
        Me.chk_detalla_anexo.Location = New System.Drawing.Point(20, 27)
        Me.chk_detalla_anexo.Name = "chk_detalla_anexo"
        Me.chk_detalla_anexo.Size = New System.Drawing.Size(112, 17)
        Me.chk_detalla_anexo.TabIndex = 14
        Me.chk_detalla_anexo.Text = "Detallar por anexo"
        Me.chk_detalla_anexo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(10, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Ruc anexo"
        '
        'txt_ruc_anexo
        '
        Me.txt_ruc_anexo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_ruc_anexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ruc_anexo.ForeColor = System.Drawing.Color.Maroon
        Me.txt_ruc_anexo.Location = New System.Drawing.Point(75, 60)
        Me.txt_ruc_anexo.Name = "txt_ruc_anexo"
        Me.txt_ruc_anexo.Size = New System.Drawing.Size(97, 20)
        Me.txt_ruc_anexo.TabIndex = 198
        '
        'Frm_MA_Conceptos_Variables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(527, 491)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_tipos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_MA_Conceptos_Variables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos Variables"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tc_tipos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgv_transacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        Me.gbCaracteristicas.ResumeLayout(False)
        Me.gbCaracteristicas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_transacciones As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_data As System.Windows.Forms.GroupBox
    Friend WithEvents gbCaracteristicas As System.Windows.Forms.GroupBox
    Friend WithEvents chk_afecto_afp As System.Windows.Forms.CheckBox
    Friend WithEvents chk_afecto_essalud As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents lblcompra As System.Windows.Forms.Label
    Friend WithEvents txtcuentaProd As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtcuentaVta As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtcuentaAdm As System.Windows.Forms.TextBox
    Friend WithEvents cbo_debe_haber As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ruc_anexo As System.Windows.Forms.TextBox
    Friend WithEvents chk_detalla_anexo As System.Windows.Forms.CheckBox
End Class
