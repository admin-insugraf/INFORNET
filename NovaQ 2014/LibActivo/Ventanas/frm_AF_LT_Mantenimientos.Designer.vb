<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_LT_Mantenimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_LT_Mantenimientos))
        Me.tc_cab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_lista = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.tc_det = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.col_idactivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DES_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_FEC_INI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_FEC_FIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_HOR_INI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_HOR_FIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_IDAREA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DES_AREA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_RESPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DES_RESPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_COD_EJE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DES_EJE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_IMG_ANT = New System.Windows.Forms.DataGridViewImageColumn()
        Me.COL_IMG_DES = New System.Windows.Forms.DataGridViewImageColumn()
        Me.COL_OBS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_datos = New System.Windows.Forms.DataGridView()
        Me.COL_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DATO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_DET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.mtb_fec_fin_det = New System.Windows.Forms.DateTimePicker()
        Me.mtb_fec_ini_det = New System.Windows.Forms.DateTimePicker()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txtobs_det = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_ejecutor_det = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmb_respo_activo = New System.Windows.Forms.ComboBox()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mtb_hor_fin = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_hor_ini = New System.Windows.Forms.MaskedTextBox()
        Me.txt_des_activo = New System.Windows.Forms.TextBox()
        Me.txt_idactivo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pb_img = New System.Windows.Forms.PictureBox()
        Me.dgv_img = New System.Windows.Forms.DataGridView()
        Me.col_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.mtb_fec_fin = New System.Windows.Forms.DateTimePicker()
        Me.mtb_fec_ini = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_ter = New System.Windows.Forms.RadioButton()
        Me.rb_per = New System.Windows.Forms.RadioButton()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.cmb_tercero = New System.Windows.Forms.ComboBox()
        Me.cmb_respo_mante = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_mante = New System.Windows.Forms.ComboBox()
        Me.txt_num_folio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.tc_cab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.tc_det.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_datos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_cab
        '
        Me.tc_cab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_cab.Controls.Add(Me.TabPage1)
        Me.tc_cab.Controls.Add(Me.TabPage2)
        Me.tc_cab.Location = New System.Drawing.Point(12, 28)
        Me.tc_cab.Name = "tc_cab"
        Me.tc_cab.SelectedIndex = 0
        Me.tc_cab.Size = New System.Drawing.Size(746, 466)
        Me.tc_cab.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_lista)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(738, 440)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Lista de Folios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_lista
        '
        Me.dgv_lista.AllowUserToAddRows = False
        Me.dgv_lista.AllowUserToDeleteRows = False
        Me.dgv_lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_lista.Location = New System.Drawing.Point(6, 6)
        Me.dgv_lista.Name = "dgv_lista"
        Me.dgv_lista.ReadOnly = True
        Me.dgv_lista.Size = New System.Drawing.Size(726, 428)
        Me.dgv_lista.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_agregar)
        Me.TabPage2.Controls.Add(Me.btn_quitar)
        Me.TabPage2.Controls.Add(Me.tc_det)
        Me.TabPage2.Controls.Add(Me.gb_datos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(738, 440)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle de Folio"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(628, 128)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(100, 25)
        Me.btn_agregar.TabIndex = 3
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_quitar
        '
        Me.btn_quitar.Location = New System.Drawing.Point(628, 161)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(100, 25)
        Me.btn_quitar.TabIndex = 2
        Me.btn_quitar.Text = "Quitar"
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'tc_det
        '
        Me.tc_det.Controls.Add(Me.TabPage3)
        Me.tc_det.Controls.Add(Me.TabPage4)
        Me.tc_det.Controls.Add(Me.TabPage5)
        Me.tc_det.Location = New System.Drawing.Point(12, 196)
        Me.tc_det.Name = "tc_det"
        Me.tc_det.SelectedIndex = 0
        Me.tc_det.Size = New System.Drawing.Size(720, 238)
        Me.tc_det.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgv_detalle)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(712, 212)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Lista de Activos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idactivo, Me.COL_DES_ACTIVO, Me.COL_FEC_INI, Me.COL_FEC_FIN, Me.COL_HOR_INI, Me.COL_HOR_FIN, Me.COL_IDAREA, Me.COL_DES_AREA, Me.COL_RESPO, Me.COL_DES_RESPO, Me.COL_COD_EJE, Me.COL_DES_EJE, Me.COL_IMG_ANT, Me.COL_IMG_DES, Me.COL_OBS})
        Me.dgv_detalle.Location = New System.Drawing.Point(6, 10)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.ReadOnly = True
        Me.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle.Size = New System.Drawing.Size(700, 196)
        Me.dgv_detalle.TabIndex = 0
        '
        'col_idactivo
        '
        Me.col_idactivo.HeaderText = "ID"
        Me.col_idactivo.Name = "col_idactivo"
        Me.col_idactivo.ReadOnly = True
        Me.col_idactivo.Width = 30
        '
        'COL_DES_ACTIVO
        '
        Me.COL_DES_ACTIVO.HeaderText = "ACTIVO"
        Me.COL_DES_ACTIVO.Name = "COL_DES_ACTIVO"
        Me.COL_DES_ACTIVO.ReadOnly = True
        '
        'COL_FEC_INI
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.COL_FEC_INI.DefaultCellStyle = DataGridViewCellStyle1
        Me.COL_FEC_INI.HeaderText = "FEC. INI"
        Me.COL_FEC_INI.Name = "COL_FEC_INI"
        Me.COL_FEC_INI.ReadOnly = True
        Me.COL_FEC_INI.Width = 60
        '
        'COL_FEC_FIN
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.COL_FEC_FIN.DefaultCellStyle = DataGridViewCellStyle2
        Me.COL_FEC_FIN.HeaderText = "FEC. FIN."
        Me.COL_FEC_FIN.Name = "COL_FEC_FIN"
        Me.COL_FEC_FIN.ReadOnly = True
        Me.COL_FEC_FIN.Width = 60
        '
        'COL_HOR_INI
        '
        Me.COL_HOR_INI.HeaderText = "HORA INI"
        Me.COL_HOR_INI.Name = "COL_HOR_INI"
        Me.COL_HOR_INI.ReadOnly = True
        Me.COL_HOR_INI.Width = 60
        '
        'COL_HOR_FIN
        '
        Me.COL_HOR_FIN.HeaderText = "HORA FIN"
        Me.COL_HOR_FIN.Name = "COL_HOR_FIN"
        Me.COL_HOR_FIN.ReadOnly = True
        Me.COL_HOR_FIN.Width = 60
        '
        'COL_IDAREA
        '
        Me.COL_IDAREA.HeaderText = "IDAREA"
        Me.COL_IDAREA.Name = "COL_IDAREA"
        Me.COL_IDAREA.ReadOnly = True
        Me.COL_IDAREA.Width = 20
        '
        'COL_DES_AREA
        '
        Me.COL_DES_AREA.HeaderText = "AREA"
        Me.COL_DES_AREA.Name = "COL_DES_AREA"
        Me.COL_DES_AREA.ReadOnly = True
        '
        'COL_RESPO
        '
        Me.COL_RESPO.HeaderText = "RESPONSABLE"
        Me.COL_RESPO.Name = "COL_RESPO"
        Me.COL_RESPO.ReadOnly = True
        Me.COL_RESPO.Width = 20
        '
        'COL_DES_RESPO
        '
        Me.COL_DES_RESPO.HeaderText = "RESPONSABLE"
        Me.COL_DES_RESPO.Name = "COL_DES_RESPO"
        Me.COL_DES_RESPO.ReadOnly = True
        '
        'COL_COD_EJE
        '
        Me.COL_COD_EJE.HeaderText = "COD EJE"
        Me.COL_COD_EJE.Name = "COL_COD_EJE"
        Me.COL_COD_EJE.ReadOnly = True
        Me.COL_COD_EJE.Width = 20
        '
        'COL_DES_EJE
        '
        Me.COL_DES_EJE.HeaderText = "EJECUTOR"
        Me.COL_DES_EJE.Name = "COL_DES_EJE"
        Me.COL_DES_EJE.ReadOnly = True
        '
        'COL_IMG_ANT
        '
        Me.COL_IMG_ANT.HeaderText = "IMG_ANT"
        Me.COL_IMG_ANT.Name = "COL_IMG_ANT"
        Me.COL_IMG_ANT.ReadOnly = True
        Me.COL_IMG_ANT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COL_IMG_ANT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'COL_IMG_DES
        '
        Me.COL_IMG_DES.HeaderText = "IMG_DES"
        Me.COL_IMG_DES.Name = "COL_IMG_DES"
        Me.COL_IMG_DES.ReadOnly = True
        Me.COL_IMG_DES.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COL_IMG_DES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'COL_OBS
        '
        Me.COL_OBS.HeaderText = "OBS"
        Me.COL_OBS.Name = "COL_OBS"
        Me.COL_OBS.ReadOnly = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(712, 212)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Detalles"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_datos)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.mtb_fec_fin_det)
        Me.GroupBox2.Controls.Add(Me.mtb_fec_ini_det)
        Me.GroupBox2.Controls.Add(Me.btn_aceptar)
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.txtobs_det)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cmb_ejecutor_det)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cmb_respo_activo)
        Me.GroupBox2.Controls.Add(Me.cmb_area)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.mtb_hor_fin)
        Me.GroupBox2.Controls.Add(Me.mtb_hor_ini)
        Me.GroupBox2.Controls.Add(Me.txt_des_activo)
        Me.GroupBox2.Controls.Add(Me.txt_idactivo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 200)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'dgv_datos
        '
        Me.dgv_datos.AllowUserToAddRows = False
        Me.dgv_datos.AllowUserToDeleteRows = False
        Me.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COL_ID, Me.COL_DATO, Me.COL_DET})
        Me.dgv_datos.Location = New System.Drawing.Point(360, 12)
        Me.dgv_datos.Name = "dgv_datos"
        Me.dgv_datos.Size = New System.Drawing.Size(267, 174)
        Me.dgv_datos.TabIndex = 29
        '
        'COL_ID
        '
        Me.COL_ID.HeaderText = "ID"
        Me.COL_ID.Name = "COL_ID"
        Me.COL_ID.ReadOnly = True
        Me.COL_ID.Width = 20
        '
        'COL_DATO
        '
        Me.COL_DATO.HeaderText = "DATO"
        Me.COL_DATO.Name = "COL_DATO"
        Me.COL_DATO.ReadOnly = True
        '
        'COL_DET
        '
        Me.COL_DET.HeaderText = "DETALLE"
        Me.COL_DET.Name = "COL_DET"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(633, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 30)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Fotos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'mtb_fec_fin_det
        '
        Me.mtb_fec_fin_det.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mtb_fec_fin_det.Location = New System.Drawing.Point(76, 64)
        Me.mtb_fec_fin_det.Name = "mtb_fec_fin_det"
        Me.mtb_fec_fin_det.Size = New System.Drawing.Size(96, 20)
        Me.mtb_fec_fin_det.TabIndex = 27
        '
        'mtb_fec_ini_det
        '
        Me.mtb_fec_ini_det.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mtb_fec_ini_det.Location = New System.Drawing.Point(76, 37)
        Me.mtb_fec_ini_det.Name = "mtb_fec_ini_det"
        Me.mtb_fec_ini_det.Size = New System.Drawing.Size(96, 20)
        Me.mtb_fec_ini_det.TabIndex = 26
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(633, 157)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(61, 30)
        Me.btn_aceptar.TabIndex = 9
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(633, 124)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(61, 30)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txtobs_det
        '
        Me.txtobs_det.Location = New System.Drawing.Point(76, 166)
        Me.txtobs_det.Name = "txtobs_det"
        Me.txtobs_det.Size = New System.Drawing.Size(275, 20)
        Me.txtobs_det.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(43, 169)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Obs"
        '
        'cmb_ejecutor_det
        '
        Me.cmb_ejecutor_det.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ejecutor_det.FormattingEnabled = True
        Me.cmb_ejecutor_det.Location = New System.Drawing.Point(76, 114)
        Me.cmb_ejecutor_det.Name = "cmb_ejecutor_det"
        Me.cmb_ejecutor_det.Size = New System.Drawing.Size(275, 21)
        Me.cmb_ejecutor_det.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(23, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Ejecutor"
        '
        'cmb_respo_activo
        '
        Me.cmb_respo_activo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_respo_activo.FormattingEnabled = True
        Me.cmb_respo_activo.Location = New System.Drawing.Point(76, 89)
        Me.cmb_respo_activo.Name = "cmb_respo_activo"
        Me.cmb_respo_activo.Size = New System.Drawing.Size(275, 21)
        Me.cmb_respo_activo.TabIndex = 6
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(76, 139)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(275, 21)
        Me.cmb_area.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(40, 143)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Area"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(5, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Responsable"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mtb_hor_fin
        '
        Me.mtb_hor_fin.Location = New System.Drawing.Point(234, 65)
        Me.mtb_hor_fin.Mask = "00:00"
        Me.mtb_hor_fin.Name = "mtb_hor_fin"
        Me.mtb_hor_fin.Size = New System.Drawing.Size(46, 20)
        Me.mtb_hor_fin.TabIndex = 4
        Me.mtb_hor_fin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtb_hor_fin.ValidatingType = GetType(Date)
        '
        'mtb_hor_ini
        '
        Me.mtb_hor_ini.Location = New System.Drawing.Point(235, 39)
        Me.mtb_hor_ini.Mask = "00:00"
        Me.mtb_hor_ini.Name = "mtb_hor_ini"
        Me.mtb_hor_ini.Size = New System.Drawing.Size(46, 20)
        Me.mtb_hor_ini.TabIndex = 3
        Me.mtb_hor_ini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtb_hor_ini.ValidatingType = GetType(Date)
        '
        'txt_des_activo
        '
        Me.txt_des_activo.Location = New System.Drawing.Point(150, 12)
        Me.txt_des_activo.Name = "txt_des_activo"
        Me.txt_des_activo.Size = New System.Drawing.Size(201, 20)
        Me.txt_des_activo.TabIndex = 16
        '
        'txt_idactivo
        '
        Me.txt_idactivo.Location = New System.Drawing.Point(76, 12)
        Me.txt_idactivo.Name = "txt_idactivo"
        Me.txt_idactivo.Size = New System.Drawing.Size(73, 20)
        Me.txt_idactivo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(182, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Hora Fin"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(182, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Hora Ini."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(24, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Fec Fin."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(27, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fec Ini."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(32, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Activo"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(712, 212)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Fotos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label48)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.pb_img)
        Me.GroupBox1.Controls.Add(Me.dgv_img)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 191)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 138)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 34)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "<=="
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Lista de Imagenes"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(519, 13)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(85, 13)
        Me.Label48.TabIndex = 17
        Me.Label48.Text = "Mini Vista Previa"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 34)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pb_img
        '
        Me.pb_img.Location = New System.Drawing.Point(522, 29)
        Me.pb_img.Name = "pb_img"
        Me.pb_img.Size = New System.Drawing.Size(153, 143)
        Me.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_img.TabIndex = 8
        Me.pb_img.TabStop = False
        '
        'dgv_img
        '
        Me.dgv_img.AllowUserToAddRows = False
        Me.dgv_img.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_img.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sec, Me.col_nom, Me.col_des, Me.col_fec, Me.col_img})
        Me.dgv_img.Location = New System.Drawing.Point(63, 29)
        Me.dgv_img.Name = "dgv_img"
        Me.dgv_img.Size = New System.Drawing.Size(453, 143)
        Me.dgv_img.TabIndex = 7
        '
        'col_sec
        '
        Me.col_sec.HeaderText = "Sec"
        Me.col_sec.Name = "col_sec"
        Me.col_sec.ReadOnly = True
        Me.col_sec.Width = 30
        '
        'col_nom
        '
        Me.col_nom.HeaderText = "Archivo"
        Me.col_nom.Name = "col_nom"
        Me.col_nom.ReadOnly = True
        '
        'col_des
        '
        Me.col_des.HeaderText = "Descripcion"
        Me.col_des.Name = "col_des"
        Me.col_des.ReadOnly = True
        '
        'col_fec
        '
        Me.col_fec.HeaderText = "fecha"
        Me.col_fec.Name = "col_fec"
        Me.col_fec.ReadOnly = True
        Me.col_fec.Width = 5
        '
        'col_img
        '
        Me.col_img.HeaderText = "Img"
        Me.col_img.Name = "col_img"
        Me.col_img.ReadOnly = True
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.mtb_fec_fin)
        Me.gb_datos.Controls.Add(Me.mtb_fec_ini)
        Me.gb_datos.Controls.Add(Me.GroupBox3)
        Me.gb_datos.Controls.Add(Me.txt_obs)
        Me.gb_datos.Controls.Add(Me.cmb_tercero)
        Me.gb_datos.Controls.Add(Me.cmb_respo_mante)
        Me.gb_datos.Controls.Add(Me.cmb_tipo_mante)
        Me.gb_datos.Controls.Add(Me.txt_num_folio)
        Me.gb_datos.Controls.Add(Me.Label8)
        Me.gb_datos.Controls.Add(Me.Label7)
        Me.gb_datos.Controls.Add(Me.Label5)
        Me.gb_datos.Controls.Add(Me.Label4)
        Me.gb_datos.Controls.Add(Me.Label3)
        Me.gb_datos.Controls.Add(Me.Label2)
        Me.gb_datos.Controls.Add(Me.Label1)
        Me.gb_datos.Location = New System.Drawing.Point(12, 4)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(610, 186)
        Me.gb_datos.TabIndex = 0
        Me.gb_datos.TabStop = False
        '
        'mtb_fec_fin
        '
        Me.mtb_fec_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mtb_fec_fin.Location = New System.Drawing.Point(309, 42)
        Me.mtb_fec_fin.Name = "mtb_fec_fin"
        Me.mtb_fec_fin.Size = New System.Drawing.Size(96, 20)
        Me.mtb_fec_fin.TabIndex = 28
        '
        'mtb_fec_ini
        '
        Me.mtb_fec_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mtb_fec_ini.Location = New System.Drawing.Point(102, 42)
        Me.mtb_fec_ini.Name = "mtb_fec_ini"
        Me.mtb_fec_ini.Size = New System.Drawing.Size(96, 20)
        Me.mtb_fec_ini.TabIndex = 27
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_ter)
        Me.GroupBox3.Controls.Add(Me.rb_per)
        Me.GroupBox3.Location = New System.Drawing.Point(440, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(114, 92)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo Ejecutor"
        '
        'rb_ter
        '
        Me.rb_ter.AutoSize = True
        Me.rb_ter.Location = New System.Drawing.Point(25, 61)
        Me.rb_ter.Name = "rb_ter"
        Me.rb_ter.Size = New System.Drawing.Size(62, 17)
        Me.rb_ter.TabIndex = 3
        Me.rb_ter.TabStop = True
        Me.rb_ter.Text = "Tercero"
        Me.rb_ter.UseVisualStyleBackColor = True
        '
        'rb_per
        '
        Me.rb_per.AutoSize = True
        Me.rb_per.Checked = True
        Me.rb_per.Location = New System.Drawing.Point(25, 25)
        Me.rb_per.Name = "rb_per"
        Me.rb_per.Size = New System.Drawing.Size(66, 17)
        Me.rb_per.TabIndex = 2
        Me.rb_per.TabStop = True
        Me.rb_per.Text = "Personal"
        Me.rb_per.UseVisualStyleBackColor = True
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(102, 148)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(485, 28)
        Me.txt_obs.TabIndex = 6
        '
        'cmb_tercero
        '
        Me.cmb_tercero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tercero.FormattingEnabled = True
        Me.cmb_tercero.Location = New System.Drawing.Point(102, 121)
        Me.cmb_tercero.Name = "cmb_tercero"
        Me.cmb_tercero.Size = New System.Drawing.Size(303, 21)
        Me.cmb_tercero.TabIndex = 5
        '
        'cmb_respo_mante
        '
        Me.cmb_respo_mante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_respo_mante.FormattingEnabled = True
        Me.cmb_respo_mante.Location = New System.Drawing.Point(102, 94)
        Me.cmb_respo_mante.Name = "cmb_respo_mante"
        Me.cmb_respo_mante.Size = New System.Drawing.Size(303, 21)
        Me.cmb_respo_mante.TabIndex = 4
        '
        'cmb_tipo_mante
        '
        Me.cmb_tipo_mante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_mante.FormattingEnabled = True
        Me.cmb_tipo_mante.Location = New System.Drawing.Point(102, 67)
        Me.cmb_tipo_mante.Name = "cmb_tipo_mante"
        Me.cmb_tipo_mante.Size = New System.Drawing.Size(185, 21)
        Me.cmb_tipo_mante.TabIndex = 3
        '
        'txt_num_folio
        '
        Me.txt_num_folio.Location = New System.Drawing.Point(102, 14)
        Me.txt_num_folio.Name = "txt_num_folio"
        Me.txt_num_folio.ReadOnly = True
        Me.txt_num_folio.Size = New System.Drawing.Size(100, 20)
        Me.txt_num_folio.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Prove - Tercero"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 33)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Responsable de Mantenimiento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Observaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tipo Manten."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fec. Termino"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fec. Inicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Folio"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.toolStripSeparator5, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator7})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(770, 25)
        Me.ToolS_Mantenimiento.TabIndex = 10
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
        Me.Tool_Grabar.Image = Global.LibActivo.My.Resources.Resources._003
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
        Me.Tool_Editar.Image = Global.LibActivo.My.Resources.Resources._16__Card_edit_
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
        'frm_AF_LT_Mantenimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 502)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.tc_cab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_LT_Mantenimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimientos"
        Me.tc_cab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.tc_det.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tc_cab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_lista As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tc_det As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents gb_datos As System.Windows.Forms.GroupBox
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tercero As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_respo_mante As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tipo_mante As System.Windows.Forms.ComboBox
    Friend WithEvents txt_num_folio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rb_ter As System.Windows.Forms.RadioButton
    Friend WithEvents rb_per As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtobs_det As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmb_ejecutor_det As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmb_respo_activo As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents mtb_hor_fin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_hor_ini As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_des_activo As System.Windows.Forms.TextBox
    Friend WithEvents txt_idactivo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pb_img As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_img As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mtb_fec_fin_det As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtb_fec_ini_det As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtb_fec_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtb_fec_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents col_sec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dgv_datos As System.Windows.Forms.DataGridView
    Friend WithEvents COL_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DATO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_idactivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DES_ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_FEC_INI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_FEC_FIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_HOR_INI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_HOR_FIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_IDAREA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DES_AREA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_RESPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DES_RESPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_COD_EJE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_DES_EJE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL_IMG_ANT As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents COL_IMG_DES As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents COL_OBS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
