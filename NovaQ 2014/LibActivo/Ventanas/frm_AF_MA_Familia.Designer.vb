<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_MA_Familia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_MA_Familia))
        Me.tc_familia = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_familia = New System.Windows.Forms.DataGridView()
        Me.FA_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA_DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CA_TASA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA_IDMETODO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA_IDCATEGORIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA_CUENTA_DEPRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA_CUENTA_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA_CUENTA_GASTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA_ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.txt_tasa = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cmb_cta_gasto = New System.Windows.Forms.ComboBox()
        Me.cmb_cta_activo = New System.Windows.Forms.ComboBox()
        Me.cmb_cta_depre = New System.Windows.Forms.ComboBox()
        Me.cmb_metodo = New System.Windows.Forms.ComboBox()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.txt_cta_gasto = New System.Windows.Forms.TextBox()
        Me.txt_cta_activo = New System.Windows.Forms.TextBox()
        Me.cmb_cat = New System.Windows.Forms.ComboBox()
        Me.txt_cta_depre = New System.Windows.Forms.TextBox()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gb_cuentas = New System.Windows.Forms.GroupBox()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dgv_cuentas_cc = New System.Windows.Forms.DataGridView()
        Me.FC_NUM_CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FC_PORCE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_porce = New System.Windows.Forms.TextBox()
        Me.txt_cta_cc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tc_familia.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_familia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gb_datos.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gb_cuentas.SuspendLayout()
        CType(Me.dgv_cuentas_cc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_familia
        '
        Me.tc_familia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_familia.Controls.Add(Me.TabPage1)
        Me.tc_familia.Controls.Add(Me.TabPage2)
        Me.tc_familia.Controls.Add(Me.TabPage3)
        Me.tc_familia.Location = New System.Drawing.Point(12, 36)
        Me.tc_familia.Name = "tc_familia"
        Me.tc_familia.SelectedIndex = 0
        Me.tc_familia.Size = New System.Drawing.Size(569, 320)
        Me.tc_familia.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_familia)
        Me.TabPage1.ForeColor = System.Drawing.Color.Navy
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(561, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Familias"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_familia
        '
        Me.dgv_familia.AllowUserToAddRows = False
        Me.dgv_familia.AllowUserToDeleteRows = False
        Me.dgv_familia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_familia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_familia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FA_ID, Me.FA_DESCRIPCION, Me.CA_TASA, Me.FA_IDMETODO, Me.FA_IDCATEGORIA, Me.FA_CUENTA_DEPRE, Me.FA_CUENTA_ACTIVO, Me.FA_CUENTA_GASTO, Me.FA_ESTADO})
        Me.dgv_familia.Location = New System.Drawing.Point(6, 6)
        Me.dgv_familia.MultiSelect = False
        Me.dgv_familia.Name = "dgv_familia"
        Me.dgv_familia.ReadOnly = True
        Me.dgv_familia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_familia.Size = New System.Drawing.Size(549, 282)
        Me.dgv_familia.TabIndex = 0
        '
        'FA_ID
        '
        Me.FA_ID.DataPropertyName = "FA_ID"
        Me.FA_ID.HeaderText = "ID"
        Me.FA_ID.Name = "FA_ID"
        Me.FA_ID.ReadOnly = True
        Me.FA_ID.Width = 50
        '
        'FA_DESCRIPCION
        '
        Me.FA_DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FA_DESCRIPCION.DataPropertyName = "FA_DESCRIPCION"
        Me.FA_DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.FA_DESCRIPCION.Name = "FA_DESCRIPCION"
        Me.FA_DESCRIPCION.ReadOnly = True
        Me.FA_DESCRIPCION.Width = 105
        '
        'CA_TASA
        '
        Me.CA_TASA.DataPropertyName = "CA_TASA"
        Me.CA_TASA.HeaderText = "Tasa%"
        Me.CA_TASA.Name = "CA_TASA"
        Me.CA_TASA.ReadOnly = True
        Me.CA_TASA.Width = 40
        '
        'FA_IDMETODO
        '
        Me.FA_IDMETODO.DataPropertyName = "FA_IDMETODO"
        Me.FA_IDMETODO.HeaderText = "FA_IDMETODO"
        Me.FA_IDMETODO.Name = "FA_IDMETODO"
        Me.FA_IDMETODO.ReadOnly = True
        Me.FA_IDMETODO.Visible = False
        Me.FA_IDMETODO.Width = 5
        '
        'FA_IDCATEGORIA
        '
        Me.FA_IDCATEGORIA.DataPropertyName = "FA_IDCATEGORIA"
        Me.FA_IDCATEGORIA.HeaderText = "FA_IDCATEGORIA"
        Me.FA_IDCATEGORIA.Name = "FA_IDCATEGORIA"
        Me.FA_IDCATEGORIA.ReadOnly = True
        Me.FA_IDCATEGORIA.Visible = False
        Me.FA_IDCATEGORIA.Width = 5
        '
        'FA_CUENTA_DEPRE
        '
        Me.FA_CUENTA_DEPRE.DataPropertyName = "FA_CUENTA_DEPRE"
        Me.FA_CUENTA_DEPRE.HeaderText = "CUENTA DEPREC."
        Me.FA_CUENTA_DEPRE.Name = "FA_CUENTA_DEPRE"
        Me.FA_CUENTA_DEPRE.ReadOnly = True
        '
        'FA_CUENTA_ACTIVO
        '
        Me.FA_CUENTA_ACTIVO.DataPropertyName = "FA_CUENTA_ACTIVO"
        Me.FA_CUENTA_ACTIVO.HeaderText = "CUENTA ACTIVO"
        Me.FA_CUENTA_ACTIVO.Name = "FA_CUENTA_ACTIVO"
        Me.FA_CUENTA_ACTIVO.ReadOnly = True
        '
        'FA_CUENTA_GASTO
        '
        Me.FA_CUENTA_GASTO.DataPropertyName = "FA_CUENTA_GASTO"
        Me.FA_CUENTA_GASTO.HeaderText = "CUENTA GASTO"
        Me.FA_CUENTA_GASTO.Name = "FA_CUENTA_GASTO"
        Me.FA_CUENTA_GASTO.ReadOnly = True
        '
        'FA_ESTADO
        '
        Me.FA_ESTADO.DataPropertyName = "FA_ESTADO"
        Me.FA_ESTADO.HeaderText = "ESTADO"
        Me.FA_ESTADO.Name = "FA_ESTADO"
        Me.FA_ESTADO.ReadOnly = True
        Me.FA_ESTADO.Width = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_datos)
        Me.TabPage2.ForeColor = System.Drawing.Color.Navy
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(561, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edicion de Datos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.txt_tasa)
        Me.gb_datos.Controls.Add(Me.Label46)
        Me.gb_datos.Controls.Add(Me.cmb_cta_gasto)
        Me.gb_datos.Controls.Add(Me.cmb_cta_activo)
        Me.gb_datos.Controls.Add(Me.cmb_cta_depre)
        Me.gb_datos.Controls.Add(Me.cmb_metodo)
        Me.gb_datos.Controls.Add(Me.chk_estado)
        Me.gb_datos.Controls.Add(Me.txt_cta_gasto)
        Me.gb_datos.Controls.Add(Me.txt_cta_activo)
        Me.gb_datos.Controls.Add(Me.cmb_cat)
        Me.gb_datos.Controls.Add(Me.txt_cta_depre)
        Me.gb_datos.Controls.Add(Me.txt_des)
        Me.gb_datos.Controls.Add(Me.txt_cod)
        Me.gb_datos.Controls.Add(Me.Label8)
        Me.gb_datos.Controls.Add(Me.Label7)
        Me.gb_datos.Controls.Add(Me.Label4)
        Me.gb_datos.Controls.Add(Me.Label6)
        Me.gb_datos.Controls.Add(Me.Label3)
        Me.gb_datos.Controls.Add(Me.Label5)
        Me.gb_datos.Controls.Add(Me.Label2)
        Me.gb_datos.Controls.Add(Me.Label1)
        Me.gb_datos.Location = New System.Drawing.Point(19, 11)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(524, 267)
        Me.gb_datos.TabIndex = 0
        Me.gb_datos.TabStop = False
        '
        'txt_tasa
        '
        Me.txt_tasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tasa.Location = New System.Drawing.Point(125, 124)
        Me.txt_tasa.Name = "txt_tasa"
        Me.txt_tasa.Size = New System.Drawing.Size(59, 20)
        Me.txt_tasa.TabIndex = 37
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(38, 127)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(80, 13)
        Me.Label46.TabIndex = 36
        Me.Label46.Text = "Tasa Deprec.%"
        '
        'cmb_cta_gasto
        '
        Me.cmb_cta_gasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cta_gasto.DropDownWidth = 400
        Me.cmb_cta_gasto.FormattingEnabled = True
        Me.cmb_cta_gasto.Location = New System.Drawing.Point(342, 207)
        Me.cmb_cta_gasto.Name = "cmb_cta_gasto"
        Me.cmb_cta_gasto.Size = New System.Drawing.Size(76, 21)
        Me.cmb_cta_gasto.TabIndex = 12
        Me.cmb_cta_gasto.Visible = False
        '
        'cmb_cta_activo
        '
        Me.cmb_cta_activo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cta_activo.DropDownWidth = 400
        Me.cmb_cta_activo.FormattingEnabled = True
        Me.cmb_cta_activo.Location = New System.Drawing.Point(342, 181)
        Me.cmb_cta_activo.Name = "cmb_cta_activo"
        Me.cmb_cta_activo.Size = New System.Drawing.Size(76, 21)
        Me.cmb_cta_activo.TabIndex = 11
        Me.cmb_cta_activo.Visible = False
        '
        'cmb_cta_depre
        '
        Me.cmb_cta_depre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cta_depre.DropDownWidth = 400
        Me.cmb_cta_depre.FormattingEnabled = True
        Me.cmb_cta_depre.Location = New System.Drawing.Point(342, 154)
        Me.cmb_cta_depre.Name = "cmb_cta_depre"
        Me.cmb_cta_depre.Size = New System.Drawing.Size(76, 21)
        Me.cmb_cta_depre.TabIndex = 10
        Me.cmb_cta_depre.Visible = False
        '
        'cmb_metodo
        '
        Me.cmb_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_metodo.FormattingEnabled = True
        Me.cmb_metodo.Items.AddRange(New Object() {"01 - METODO LINEAL "})
        Me.cmb_metodo.Location = New System.Drawing.Point(125, 68)
        Me.cmb_metodo.Name = "cmb_metodo"
        Me.cmb_metodo.Size = New System.Drawing.Size(293, 21)
        Me.cmb_metodo.TabIndex = 9
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.ForeColor = System.Drawing.Color.Navy
        Me.chk_estado.Location = New System.Drawing.Point(124, 238)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(56, 17)
        Me.chk_estado.TabIndex = 8
        Me.chk_estado.Text = "Activo"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'txt_cta_gasto
        '
        Me.txt_cta_gasto.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cta_gasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cta_gasto.Location = New System.Drawing.Point(124, 207)
        Me.txt_cta_gasto.Name = "txt_cta_gasto"
        Me.txt_cta_gasto.ReadOnly = True
        Me.txt_cta_gasto.Size = New System.Drawing.Size(127, 20)
        Me.txt_cta_gasto.TabIndex = 7
        '
        'txt_cta_activo
        '
        Me.txt_cta_activo.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cta_activo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cta_activo.Location = New System.Drawing.Point(124, 181)
        Me.txt_cta_activo.Name = "txt_cta_activo"
        Me.txt_cta_activo.ReadOnly = True
        Me.txt_cta_activo.Size = New System.Drawing.Size(127, 20)
        Me.txt_cta_activo.TabIndex = 6
        '
        'cmb_cat
        '
        Me.cmb_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cat.FormattingEnabled = True
        Me.cmb_cat.Location = New System.Drawing.Point(125, 97)
        Me.cmb_cat.Name = "cmb_cat"
        Me.cmb_cat.Size = New System.Drawing.Size(293, 21)
        Me.cmb_cat.TabIndex = 5
        '
        'txt_cta_depre
        '
        Me.txt_cta_depre.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_cta_depre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cta_depre.Location = New System.Drawing.Point(124, 154)
        Me.txt_cta_depre.Name = "txt_cta_depre"
        Me.txt_cta_depre.ReadOnly = True
        Me.txt_cta_depre.Size = New System.Drawing.Size(127, 20)
        Me.txt_cta_depre.TabIndex = 4
        '
        'txt_des
        '
        Me.txt_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_des.Location = New System.Drawing.Point(124, 44)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(294, 20)
        Me.txt_des.TabIndex = 2
        '
        'txt_cod
        '
        Me.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod.Location = New System.Drawing.Point(125, 17)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(59, 20)
        Me.txt_cod.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(78, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Estado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(46, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cuenta Gasto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(66, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Categoria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(44, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cuenta Activo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(22, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Metodo de Calculo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(11, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cuenta Depreciacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(55, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(78, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gb_cuentas)
        Me.TabPage3.ForeColor = System.Drawing.Color.Navy
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(561, 294)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cuentas Centro Costo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gb_cuentas
        '
        Me.gb_cuentas.Controls.Add(Me.btn_quitar)
        Me.gb_cuentas.Controls.Add(Me.btn_agregar)
        Me.gb_cuentas.Controls.Add(Me.dgv_cuentas_cc)
        Me.gb_cuentas.Controls.Add(Me.txt_porce)
        Me.gb_cuentas.Controls.Add(Me.txt_cta_cc)
        Me.gb_cuentas.Controls.Add(Me.Label10)
        Me.gb_cuentas.Location = New System.Drawing.Point(6, 6)
        Me.gb_cuentas.Name = "gb_cuentas"
        Me.gb_cuentas.Size = New System.Drawing.Size(549, 282)
        Me.gb_cuentas.TabIndex = 0
        Me.gb_cuentas.TabStop = False
        '
        'btn_quitar
        '
        Me.btn_quitar.Image = CType(resources.GetObject("btn_quitar.Image"), System.Drawing.Image)
        Me.btn_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_quitar.Location = New System.Drawing.Point(363, 31)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(72, 23)
        Me.btn_quitar.TabIndex = 41
        Me.btn_quitar.Text = "Quitar"
        Me.btn_quitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = CType(resources.GetObject("btn_agregar.Image"), System.Drawing.Image)
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar.Location = New System.Drawing.Point(285, 31)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(72, 23)
        Me.btn_agregar.TabIndex = 40
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dgv_cuentas_cc
        '
        Me.dgv_cuentas_cc.AllowUserToAddRows = False
        Me.dgv_cuentas_cc.AllowUserToDeleteRows = False
        Me.dgv_cuentas_cc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cuentas_cc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FC_NUM_CUENTA, Me.FC_PORCE})
        Me.dgv_cuentas_cc.Location = New System.Drawing.Point(24, 59)
        Me.dgv_cuentas_cc.Name = "dgv_cuentas_cc"
        Me.dgv_cuentas_cc.ReadOnly = True
        Me.dgv_cuentas_cc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cuentas_cc.Size = New System.Drawing.Size(264, 206)
        Me.dgv_cuentas_cc.TabIndex = 39
        '
        'FC_NUM_CUENTA
        '
        Me.FC_NUM_CUENTA.DataPropertyName = "FC_NUM_CUENTA"
        Me.FC_NUM_CUENTA.HeaderText = "Num. Cuenta C.C."
        Me.FC_NUM_CUENTA.Name = "FC_NUM_CUENTA"
        Me.FC_NUM_CUENTA.ReadOnly = True
        '
        'FC_PORCE
        '
        Me.FC_PORCE.DataPropertyName = "FC_PORCE"
        Me.FC_PORCE.HeaderText = "Porcentaje Prorrateo"
        Me.FC_PORCE.Name = "FC_PORCE"
        Me.FC_PORCE.ReadOnly = True
        '
        'txt_porce
        '
        Me.txt_porce.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_porce.Location = New System.Drawing.Point(242, 33)
        Me.txt_porce.Name = "txt_porce"
        Me.txt_porce.Size = New System.Drawing.Size(37, 20)
        Me.txt_porce.TabIndex = 38
        '
        'txt_cta_cc
        '
        Me.txt_cta_cc.Location = New System.Drawing.Point(91, 33)
        Me.txt_cta_cc.Name = "txt_cta_cc"
        Me.txt_cta_cc.Size = New System.Drawing.Size(145, 20)
        Me.txt_cta_cc.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(21, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Cuenta C.C."
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.toolStripSeparator5, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator7})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(593, 25)
        Me.ToolS_Mantenimiento.TabIndex = 9
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Nuevo.Image = Global.LibActivo.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = CType(resources.GetObject("Tool_Grabar.Image"), System.Drawing.Image)
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = CType(resources.GetObject("Tool_Editar.Image"), System.Drawing.Image)
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.LibActivo.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.LibActivo.My.Resources.Resources._16__Delete_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.LibActivo.My.Resources.Resources._16__Exit_
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'frm_AF_MA_Familia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(593, 368)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.tc_familia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_MA_Familia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Familias"
        Me.tc_familia.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_familia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.gb_cuentas.ResumeLayout(False)
        Me.gb_cuentas.PerformLayout()
        CType(Me.dgv_cuentas_cc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_familia As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_familia As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chk_estado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cta_gasto As System.Windows.Forms.TextBox
    Friend WithEvents txt_cta_activo As System.Windows.Forms.TextBox
    Friend WithEvents cmb_cat As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cta_depre As System.Windows.Forms.TextBox
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_metodo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cta_gasto As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cta_activo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cta_depre As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tasa As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents gb_cuentas As System.Windows.Forms.GroupBox
    Friend WithEvents txt_porce As System.Windows.Forms.TextBox
    Friend WithEvents txt_cta_cc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents dgv_cuentas_cc As System.Windows.Forms.DataGridView
    Friend WithEvents FC_NUM_CUENTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FC_PORCE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CA_TASA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_IDMETODO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_IDCATEGORIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_CUENTA_DEPRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_CUENTA_ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_CUENTA_GASTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
