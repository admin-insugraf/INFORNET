<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_RP_BalCompro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_RP_BalCompro))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_consultar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_regresar = New System.Windows.Forms.ToolStripButton()
        Me.btn_actualizar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_solo_ctas_tit = New System.Windows.Forms.CheckBox()
        Me.chk_con_cta_tit = New System.Windows.Forms.CheckBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_acumulado = New System.Windows.Forms.RadioButton()
        Me.rb_mensual = New System.Windows.Forms.RadioButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_Moneda = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.mtb_ayo = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inv_activo_3 = New System.Windows.Forms.MaskedTextBox()
        Me.inv_pasivo_3 = New System.Windows.Forms.MaskedTextBox()
        Me.natu_ganancia_3 = New System.Windows.Forms.MaskedTextBox()
        Me.fun_perdida_3 = New System.Windows.Forms.MaskedTextBox()
        Me.fun_ganancia_3 = New System.Windows.Forms.MaskedTextBox()
        Me.natu_perdida_3 = New System.Windows.Forms.MaskedTextBox()
        Me.inv_activo_2 = New System.Windows.Forms.MaskedTextBox()
        Me.inv_pasivo_2 = New System.Windows.Forms.MaskedTextBox()
        Me.natu_ganancia_2 = New System.Windows.Forms.MaskedTextBox()
        Me.fun_perdida_2 = New System.Windows.Forms.MaskedTextBox()
        Me.fun_ganancia_2 = New System.Windows.Forms.MaskedTextBox()
        Me.natu_perdida_2 = New System.Windows.Forms.MaskedTextBox()
        Me.saldo_acreedor = New System.Windows.Forms.MaskedTextBox()
        Me.inv_activo = New System.Windows.Forms.MaskedTextBox()
        Me.inv_pasivo = New System.Windows.Forms.MaskedTextBox()
        Me.saldo_deudor = New System.Windows.Forms.MaskedTextBox()
        Me.natu_ganancia = New System.Windows.Forms.MaskedTextBox()
        Me.fun_perdida = New System.Windows.Forms.MaskedTextBox()
        Me.fun_ganancia = New System.Windows.Forms.MaskedTextBox()
        Me.natu_perdida = New System.Windows.Forms.MaskedTextBox()
        Me.si_credito = New System.Windows.Forms.MaskedTextBox()
        Me.mov_debito = New System.Windows.Forms.MaskedTextBox()
        Me.mov_credito = New System.Windows.Forms.MaskedTextBox()
        Me.si_debito = New System.Windows.Forms.MaskedTextBox()
        Me.dgv_movimiento_cuenta = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_total_monto_original = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.total_cuenta_haber = New System.Windows.Forms.MaskedTextBox()
        Me.total_cuenta_debe = New System.Windows.Forms.MaskedTextBox()
        Me.total_mov_haber = New System.Windows.Forms.MaskedTextBox()
        Me.total_mov_debe = New System.Windows.Forms.MaskedTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_movimiento_cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_consultar, Me.Tool_imprimir, Me.btn_regresar, Me.btn_actualizar, Me.Tool_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1326, 25)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(81, 22)
        Me.btn_consultar.Text = "&Consultar"
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = CType(resources.GetObject("Tool_imprimir.Image"), System.Drawing.Image)
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(118, 22)
        Me.Tool_imprimir.Text = "&Mostrar reporte"
        Me.Tool_imprimir.ToolTipText = "Imprimir"
        '
        'btn_regresar
        '
        Me.btn_regresar.Image = CType(resources.GetObject("btn_regresar.Image"), System.Drawing.Image)
        Me.btn_regresar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(79, 22)
        Me.btn_regresar.Text = "&Regresar"
        Me.btn_regresar.Visible = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Image = CType(resources.GetObject("btn_actualizar.Image"), System.Drawing.Image)
        Me.btn_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(84, 22)
        Me.btn_actualizar.Text = "&Actualizar"
        Me.btn_actualizar.Visible = False
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = CType(resources.GetObject("Tool_salir.Image"), System.Drawing.Image)
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(52, 22)
        Me.Tool_salir.Text = "&Salir"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.chk_solo_ctas_tit)
        Me.groupBox3.Controls.Add(Me.chk_con_cta_tit)
        Me.groupBox3.ForeColor = System.Drawing.Color.Navy
        Me.groupBox3.Location = New System.Drawing.Point(671, 28)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(267, 40)
        Me.groupBox3.TabIndex = 24
        Me.groupBox3.TabStop = False
        '
        'chk_solo_ctas_tit
        '
        Me.chk_solo_ctas_tit.AutoSize = True
        Me.chk_solo_ctas_tit.ForeColor = System.Drawing.Color.Navy
        Me.chk_solo_ctas_tit.Location = New System.Drawing.Point(153, 15)
        Me.chk_solo_ctas_tit.Name = "chk_solo_ctas_tit"
        Me.chk_solo_ctas_tit.Size = New System.Drawing.Size(103, 17)
        Me.chk_solo_ctas_tit.TabIndex = 0
        Me.chk_solo_ctas_tit.Text = "Solo Ctas Titutlo"
        Me.chk_solo_ctas_tit.UseVisualStyleBackColor = True
        '
        'chk_con_cta_tit
        '
        Me.chk_con_cta_tit.AutoSize = True
        Me.chk_con_cta_tit.ForeColor = System.Drawing.Color.Navy
        Me.chk_con_cta_tit.Location = New System.Drawing.Point(16, 15)
        Me.chk_con_cta_tit.Name = "chk_con_cta_tit"
        Me.chk_con_cta_tit.Size = New System.Drawing.Size(131, 17)
        Me.chk_con_cta_tit.TabIndex = 0
        Me.chk_con_cta_tit.Text = "Con Cuentas de Titulo"
        Me.chk_con_cta_tit.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rb_acumulado)
        Me.groupBox1.Controls.Add(Me.rb_mensual)
        Me.groupBox1.Location = New System.Drawing.Point(486, 28)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(179, 40)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        '
        'rb_acumulado
        '
        Me.rb_acumulado.AutoSize = True
        Me.rb_acumulado.Checked = True
        Me.rb_acumulado.ForeColor = System.Drawing.Color.Navy
        Me.rb_acumulado.Location = New System.Drawing.Point(89, 13)
        Me.rb_acumulado.Name = "rb_acumulado"
        Me.rb_acumulado.Size = New System.Drawing.Size(78, 17)
        Me.rb_acumulado.TabIndex = 4
        Me.rb_acumulado.TabStop = True
        Me.rb_acumulado.Text = "Acumulado"
        Me.rb_acumulado.UseVisualStyleBackColor = True
        '
        'rb_mensual
        '
        Me.rb_mensual.AutoSize = True
        Me.rb_mensual.ForeColor = System.Drawing.Color.Navy
        Me.rb_mensual.Location = New System.Drawing.Point(15, 13)
        Me.rb_mensual.Name = "rb_mensual"
        Me.rb_mensual.Size = New System.Drawing.Size(65, 17)
        Me.rb_mensual.TabIndex = 3
        Me.rb_mensual.Text = "Mensual"
        Me.rb_mensual.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cmb_Moneda)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.cmb_mes)
        Me.groupBox2.Controls.Add(Me.mtb_ayo)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Location = New System.Drawing.Point(11, 28)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(469, 40)
        Me.groupBox2.TabIndex = 22
        Me.groupBox2.TabStop = False
        '
        'cmb_Moneda
        '
        Me.cmb_Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Moneda.FormattingEnabled = True
        Me.cmb_Moneda.Location = New System.Drawing.Point(283, 12)
        Me.cmb_Moneda.Name = "cmb_Moneda"
        Me.cmb_Moneda.Size = New System.Drawing.Size(169, 21)
        Me.cmb_Moneda.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(231, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(46, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Moneda"
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(113, 12)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(112, 21)
        Me.cmb_mes.TabIndex = 2
        '
        'mtb_ayo
        '
        Me.mtb_ayo.Location = New System.Drawing.Point(61, 12)
        Me.mtb_ayo.Mask = "9999"
        Me.mtb_ayo.Name = "mtb_ayo"
        Me.mtb_ayo.Size = New System.Drawing.Size(42, 20)
        Me.mtb_ayo.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(12, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Periodo"
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AllowUserToDeleteRows = False
        Me.dgv_detalle.AllowUserToResizeColumns = False
        Me.dgv_detalle.AllowUserToResizeRows = False
        Me.dgv_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Location = New System.Drawing.Point(11, 72)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.ReadOnly = True
        Me.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle.Size = New System.Drawing.Size(1301, 382)
        Me.dgv_detalle.TabIndex = 25
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.inv_activo_3)
        Me.GroupBox4.Controls.Add(Me.inv_pasivo_3)
        Me.GroupBox4.Controls.Add(Me.natu_ganancia_3)
        Me.GroupBox4.Controls.Add(Me.fun_perdida_3)
        Me.GroupBox4.Controls.Add(Me.fun_ganancia_3)
        Me.GroupBox4.Controls.Add(Me.natu_perdida_3)
        Me.GroupBox4.Controls.Add(Me.inv_activo_2)
        Me.GroupBox4.Controls.Add(Me.inv_pasivo_2)
        Me.GroupBox4.Controls.Add(Me.natu_ganancia_2)
        Me.GroupBox4.Controls.Add(Me.fun_perdida_2)
        Me.GroupBox4.Controls.Add(Me.fun_ganancia_2)
        Me.GroupBox4.Controls.Add(Me.natu_perdida_2)
        Me.GroupBox4.Controls.Add(Me.saldo_acreedor)
        Me.GroupBox4.Controls.Add(Me.inv_activo)
        Me.GroupBox4.Controls.Add(Me.inv_pasivo)
        Me.GroupBox4.Controls.Add(Me.saldo_deudor)
        Me.GroupBox4.Controls.Add(Me.natu_ganancia)
        Me.GroupBox4.Controls.Add(Me.fun_perdida)
        Me.GroupBox4.Controls.Add(Me.fun_ganancia)
        Me.GroupBox4.Controls.Add(Me.natu_perdida)
        Me.GroupBox4.Controls.Add(Me.si_credito)
        Me.GroupBox4.Controls.Add(Me.mov_debito)
        Me.GroupBox4.Controls.Add(Me.mov_credito)
        Me.GroupBox4.Controls.Add(Me.si_debito)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 455)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1301, 89)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(172, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "TOTALES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(172, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "SALDOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(172, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "SUMAS"
        '
        'inv_activo_3
        '
        Me.inv_activo_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.inv_activo_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inv_activo_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inv_activo_3.ForeColor = System.Drawing.Color.Navy
        Me.inv_activo_3.Location = New System.Drawing.Point(776, 59)
        Me.inv_activo_3.Name = "inv_activo_3"
        Me.inv_activo_3.ReadOnly = True
        Me.inv_activo_3.Size = New System.Drawing.Size(86, 21)
        Me.inv_activo_3.TabIndex = 61
        Me.inv_activo_3.Text = "0.00"
        Me.inv_activo_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'inv_pasivo_3
        '
        Me.inv_pasivo_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.inv_pasivo_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inv_pasivo_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inv_pasivo_3.ForeColor = System.Drawing.Color.Navy
        Me.inv_pasivo_3.Location = New System.Drawing.Point(866, 59)
        Me.inv_pasivo_3.Name = "inv_pasivo_3"
        Me.inv_pasivo_3.ReadOnly = True
        Me.inv_pasivo_3.Size = New System.Drawing.Size(86, 21)
        Me.inv_pasivo_3.TabIndex = 60
        Me.inv_pasivo_3.Text = "0.00"
        Me.inv_pasivo_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'natu_ganancia_3
        '
        Me.natu_ganancia_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.natu_ganancia_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.natu_ganancia_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.natu_ganancia_3.ForeColor = System.Drawing.Color.Navy
        Me.natu_ganancia_3.Location = New System.Drawing.Point(1045, 59)
        Me.natu_ganancia_3.Name = "natu_ganancia_3"
        Me.natu_ganancia_3.ReadOnly = True
        Me.natu_ganancia_3.Size = New System.Drawing.Size(86, 21)
        Me.natu_ganancia_3.TabIndex = 58
        Me.natu_ganancia_3.Text = "0.00"
        Me.natu_ganancia_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fun_perdida_3
        '
        Me.fun_perdida_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fun_perdida_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fun_perdida_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fun_perdida_3.ForeColor = System.Drawing.Color.Navy
        Me.fun_perdida_3.Location = New System.Drawing.Point(1134, 59)
        Me.fun_perdida_3.Name = "fun_perdida_3"
        Me.fun_perdida_3.ReadOnly = True
        Me.fun_perdida_3.Size = New System.Drawing.Size(86, 21)
        Me.fun_perdida_3.TabIndex = 59
        Me.fun_perdida_3.Text = "0.00"
        Me.fun_perdida_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fun_ganancia_3
        '
        Me.fun_ganancia_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fun_ganancia_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fun_ganancia_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fun_ganancia_3.ForeColor = System.Drawing.Color.Navy
        Me.fun_ganancia_3.Location = New System.Drawing.Point(1224, 59)
        Me.fun_ganancia_3.Name = "fun_ganancia_3"
        Me.fun_ganancia_3.ReadOnly = True
        Me.fun_ganancia_3.Size = New System.Drawing.Size(86, 21)
        Me.fun_ganancia_3.TabIndex = 56
        Me.fun_ganancia_3.Text = "0.00"
        Me.fun_ganancia_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'natu_perdida_3
        '
        Me.natu_perdida_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.natu_perdida_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.natu_perdida_3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.natu_perdida_3.ForeColor = System.Drawing.Color.Navy
        Me.natu_perdida_3.Location = New System.Drawing.Point(956, 59)
        Me.natu_perdida_3.Name = "natu_perdida_3"
        Me.natu_perdida_3.ReadOnly = True
        Me.natu_perdida_3.Size = New System.Drawing.Size(86, 21)
        Me.natu_perdida_3.TabIndex = 57
        Me.natu_perdida_3.Text = "0.00"
        Me.natu_perdida_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'inv_activo_2
        '
        Me.inv_activo_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.inv_activo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inv_activo_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inv_activo_2.ForeColor = System.Drawing.Color.Navy
        Me.inv_activo_2.Location = New System.Drawing.Point(776, 35)
        Me.inv_activo_2.Name = "inv_activo_2"
        Me.inv_activo_2.ReadOnly = True
        Me.inv_activo_2.Size = New System.Drawing.Size(86, 21)
        Me.inv_activo_2.TabIndex = 55
        Me.inv_activo_2.Text = "0.00"
        Me.inv_activo_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'inv_pasivo_2
        '
        Me.inv_pasivo_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.inv_pasivo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inv_pasivo_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inv_pasivo_2.ForeColor = System.Drawing.Color.Navy
        Me.inv_pasivo_2.Location = New System.Drawing.Point(866, 35)
        Me.inv_pasivo_2.Name = "inv_pasivo_2"
        Me.inv_pasivo_2.ReadOnly = True
        Me.inv_pasivo_2.Size = New System.Drawing.Size(86, 21)
        Me.inv_pasivo_2.TabIndex = 54
        Me.inv_pasivo_2.Text = "0.00"
        Me.inv_pasivo_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'natu_ganancia_2
        '
        Me.natu_ganancia_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.natu_ganancia_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.natu_ganancia_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.natu_ganancia_2.ForeColor = System.Drawing.Color.Navy
        Me.natu_ganancia_2.Location = New System.Drawing.Point(1045, 35)
        Me.natu_ganancia_2.Name = "natu_ganancia_2"
        Me.natu_ganancia_2.ReadOnly = True
        Me.natu_ganancia_2.Size = New System.Drawing.Size(86, 21)
        Me.natu_ganancia_2.TabIndex = 52
        Me.natu_ganancia_2.Text = "0.00"
        Me.natu_ganancia_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fun_perdida_2
        '
        Me.fun_perdida_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fun_perdida_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fun_perdida_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fun_perdida_2.ForeColor = System.Drawing.Color.Navy
        Me.fun_perdida_2.Location = New System.Drawing.Point(1134, 35)
        Me.fun_perdida_2.Name = "fun_perdida_2"
        Me.fun_perdida_2.ReadOnly = True
        Me.fun_perdida_2.Size = New System.Drawing.Size(86, 21)
        Me.fun_perdida_2.TabIndex = 53
        Me.fun_perdida_2.Text = "0.00"
        Me.fun_perdida_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fun_ganancia_2
        '
        Me.fun_ganancia_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fun_ganancia_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fun_ganancia_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fun_ganancia_2.ForeColor = System.Drawing.Color.Navy
        Me.fun_ganancia_2.Location = New System.Drawing.Point(1224, 35)
        Me.fun_ganancia_2.Name = "fun_ganancia_2"
        Me.fun_ganancia_2.ReadOnly = True
        Me.fun_ganancia_2.Size = New System.Drawing.Size(86, 21)
        Me.fun_ganancia_2.TabIndex = 50
        Me.fun_ganancia_2.Text = "0.00"
        Me.fun_ganancia_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'natu_perdida_2
        '
        Me.natu_perdida_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.natu_perdida_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.natu_perdida_2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.natu_perdida_2.ForeColor = System.Drawing.Color.Navy
        Me.natu_perdida_2.Location = New System.Drawing.Point(956, 35)
        Me.natu_perdida_2.Name = "natu_perdida_2"
        Me.natu_perdida_2.ReadOnly = True
        Me.natu_perdida_2.Size = New System.Drawing.Size(86, 21)
        Me.natu_perdida_2.TabIndex = 51
        Me.natu_perdida_2.Text = "0.00"
        Me.natu_perdida_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'saldo_acreedor
        '
        Me.saldo_acreedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.saldo_acreedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.saldo_acreedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_acreedor.ForeColor = System.Drawing.Color.Navy
        Me.saldo_acreedor.Location = New System.Drawing.Point(684, 12)
        Me.saldo_acreedor.Name = "saldo_acreedor"
        Me.saldo_acreedor.ReadOnly = True
        Me.saldo_acreedor.Size = New System.Drawing.Size(86, 21)
        Me.saldo_acreedor.TabIndex = 48
        Me.saldo_acreedor.Text = "0.00"
        Me.saldo_acreedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'inv_activo
        '
        Me.inv_activo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.inv_activo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inv_activo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inv_activo.ForeColor = System.Drawing.Color.Navy
        Me.inv_activo.Location = New System.Drawing.Point(776, 12)
        Me.inv_activo.Name = "inv_activo"
        Me.inv_activo.ReadOnly = True
        Me.inv_activo.Size = New System.Drawing.Size(86, 21)
        Me.inv_activo.TabIndex = 49
        Me.inv_activo.Text = "0.00"
        Me.inv_activo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'inv_pasivo
        '
        Me.inv_pasivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.inv_pasivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inv_pasivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inv_pasivo.ForeColor = System.Drawing.Color.Navy
        Me.inv_pasivo.Location = New System.Drawing.Point(866, 12)
        Me.inv_pasivo.Name = "inv_pasivo"
        Me.inv_pasivo.ReadOnly = True
        Me.inv_pasivo.Size = New System.Drawing.Size(86, 21)
        Me.inv_pasivo.TabIndex = 46
        Me.inv_pasivo.Text = "0.00"
        Me.inv_pasivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'saldo_deudor
        '
        Me.saldo_deudor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.saldo_deudor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.saldo_deudor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo_deudor.ForeColor = System.Drawing.Color.Navy
        Me.saldo_deudor.Location = New System.Drawing.Point(595, 12)
        Me.saldo_deudor.Name = "saldo_deudor"
        Me.saldo_deudor.ReadOnly = True
        Me.saldo_deudor.Size = New System.Drawing.Size(86, 21)
        Me.saldo_deudor.TabIndex = 47
        Me.saldo_deudor.Text = "0.00"
        Me.saldo_deudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'natu_ganancia
        '
        Me.natu_ganancia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.natu_ganancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.natu_ganancia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.natu_ganancia.ForeColor = System.Drawing.Color.Navy
        Me.natu_ganancia.Location = New System.Drawing.Point(1045, 12)
        Me.natu_ganancia.Name = "natu_ganancia"
        Me.natu_ganancia.ReadOnly = True
        Me.natu_ganancia.Size = New System.Drawing.Size(86, 21)
        Me.natu_ganancia.TabIndex = 44
        Me.natu_ganancia.Text = "0.00"
        Me.natu_ganancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fun_perdida
        '
        Me.fun_perdida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fun_perdida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fun_perdida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fun_perdida.ForeColor = System.Drawing.Color.Navy
        Me.fun_perdida.Location = New System.Drawing.Point(1134, 12)
        Me.fun_perdida.Name = "fun_perdida"
        Me.fun_perdida.ReadOnly = True
        Me.fun_perdida.Size = New System.Drawing.Size(86, 21)
        Me.fun_perdida.TabIndex = 45
        Me.fun_perdida.Text = "0.00"
        Me.fun_perdida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fun_ganancia
        '
        Me.fun_ganancia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fun_ganancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fun_ganancia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fun_ganancia.ForeColor = System.Drawing.Color.Navy
        Me.fun_ganancia.Location = New System.Drawing.Point(1224, 12)
        Me.fun_ganancia.Name = "fun_ganancia"
        Me.fun_ganancia.ReadOnly = True
        Me.fun_ganancia.Size = New System.Drawing.Size(86, 21)
        Me.fun_ganancia.TabIndex = 42
        Me.fun_ganancia.Text = "0.00"
        Me.fun_ganancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'natu_perdida
        '
        Me.natu_perdida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.natu_perdida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.natu_perdida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.natu_perdida.ForeColor = System.Drawing.Color.Navy
        Me.natu_perdida.Location = New System.Drawing.Point(956, 12)
        Me.natu_perdida.Name = "natu_perdida"
        Me.natu_perdida.ReadOnly = True
        Me.natu_perdida.Size = New System.Drawing.Size(86, 21)
        Me.natu_perdida.TabIndex = 43
        Me.natu_perdida.Text = "0.00"
        Me.natu_perdida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'si_credito
        '
        Me.si_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.si_credito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.si_credito.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si_credito.ForeColor = System.Drawing.Color.Navy
        Me.si_credito.Location = New System.Drawing.Point(325, 12)
        Me.si_credito.Name = "si_credito"
        Me.si_credito.ReadOnly = True
        Me.si_credito.Size = New System.Drawing.Size(86, 21)
        Me.si_credito.TabIndex = 40
        Me.si_credito.Text = "0.00"
        Me.si_credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mov_debito
        '
        Me.mov_debito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mov_debito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mov_debito.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mov_debito.ForeColor = System.Drawing.Color.Navy
        Me.mov_debito.Location = New System.Drawing.Point(414, 12)
        Me.mov_debito.Name = "mov_debito"
        Me.mov_debito.ReadOnly = True
        Me.mov_debito.Size = New System.Drawing.Size(86, 21)
        Me.mov_debito.TabIndex = 41
        Me.mov_debito.Text = "0.00"
        Me.mov_debito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mov_credito
        '
        Me.mov_credito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mov_credito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mov_credito.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mov_credito.ForeColor = System.Drawing.Color.Navy
        Me.mov_credito.Location = New System.Drawing.Point(504, 12)
        Me.mov_credito.Name = "mov_credito"
        Me.mov_credito.ReadOnly = True
        Me.mov_credito.Size = New System.Drawing.Size(86, 21)
        Me.mov_credito.TabIndex = 38
        Me.mov_credito.Text = "0.00"
        Me.mov_credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'si_debito
        '
        Me.si_debito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.si_debito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.si_debito.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.si_debito.ForeColor = System.Drawing.Color.Navy
        Me.si_debito.Location = New System.Drawing.Point(234, 12)
        Me.si_debito.Name = "si_debito"
        Me.si_debito.ReadOnly = True
        Me.si_debito.Size = New System.Drawing.Size(86, 21)
        Me.si_debito.TabIndex = 39
        Me.si_debito.Text = "0.00"
        Me.si_debito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgv_movimiento_cuenta
        '
        Me.dgv_movimiento_cuenta.AllowUserToAddRows = False
        Me.dgv_movimiento_cuenta.AllowUserToDeleteRows = False
        Me.dgv_movimiento_cuenta.AllowUserToResizeColumns = False
        Me.dgv_movimiento_cuenta.AllowUserToResizeRows = False
        Me.dgv_movimiento_cuenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_movimiento_cuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_movimiento_cuenta.Location = New System.Drawing.Point(11, 72)
        Me.dgv_movimiento_cuenta.Name = "dgv_movimiento_cuenta"
        Me.dgv_movimiento_cuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_movimiento_cuenta.Size = New System.Drawing.Size(1302, 382)
        Me.dgv_movimiento_cuenta.TabIndex = 39
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txt_total_monto_original)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.total_cuenta_haber)
        Me.GroupBox5.Controls.Add(Me.total_cuenta_debe)
        Me.GroupBox5.Controls.Add(Me.total_mov_haber)
        Me.GroupBox5.Controls.Add(Me.total_mov_debe)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 455)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1300, 89)
        Me.GroupBox5.TabIndex = 70
        Me.GroupBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(978, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "TOTAL MONTO ORIGINAL"
        '
        'txt_total_monto_original
        '
        Me.txt_total_monto_original.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_total_monto_original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_monto_original.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_monto_original.ForeColor = System.Drawing.Color.Navy
        Me.txt_total_monto_original.Location = New System.Drawing.Point(1136, 27)
        Me.txt_total_monto_original.Name = "txt_total_monto_original"
        Me.txt_total_monto_original.ReadOnly = True
        Me.txt_total_monto_original.Size = New System.Drawing.Size(86, 21)
        Me.txt_total_monto_original.TabIndex = 76
        Me.txt_total_monto_original.Text = "0.00"
        Me.txt_total_monto_original.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(370, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "TOTAL MOV. CUENTA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(370, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "TOTAL CUENTA CONTABLE"
        '
        'total_cuenta_haber
        '
        Me.total_cuenta_haber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.total_cuenta_haber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total_cuenta_haber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_cuenta_haber.ForeColor = System.Drawing.Color.Navy
        Me.total_cuenta_haber.Location = New System.Drawing.Point(616, 27)
        Me.total_cuenta_haber.Name = "total_cuenta_haber"
        Me.total_cuenta_haber.ReadOnly = True
        Me.total_cuenta_haber.Size = New System.Drawing.Size(86, 21)
        Me.total_cuenta_haber.TabIndex = 73
        Me.total_cuenta_haber.Text = "0.00"
        Me.total_cuenta_haber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'total_cuenta_debe
        '
        Me.total_cuenta_debe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.total_cuenta_debe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total_cuenta_debe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_cuenta_debe.ForeColor = System.Drawing.Color.Navy
        Me.total_cuenta_debe.Location = New System.Drawing.Point(525, 27)
        Me.total_cuenta_debe.Name = "total_cuenta_debe"
        Me.total_cuenta_debe.ReadOnly = True
        Me.total_cuenta_debe.Size = New System.Drawing.Size(86, 21)
        Me.total_cuenta_debe.TabIndex = 72
        Me.total_cuenta_debe.Text = "0.00"
        Me.total_cuenta_debe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'total_mov_haber
        '
        Me.total_mov_haber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.total_mov_haber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total_mov_haber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_mov_haber.ForeColor = System.Drawing.Color.Navy
        Me.total_mov_haber.Location = New System.Drawing.Point(616, 53)
        Me.total_mov_haber.Name = "total_mov_haber"
        Me.total_mov_haber.ReadOnly = True
        Me.total_mov_haber.Size = New System.Drawing.Size(86, 21)
        Me.total_mov_haber.TabIndex = 71
        Me.total_mov_haber.Text = "0.00"
        Me.total_mov_haber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'total_mov_debe
        '
        Me.total_mov_debe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.total_mov_debe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total_mov_debe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_mov_debe.ForeColor = System.Drawing.Color.Navy
        Me.total_mov_debe.Location = New System.Drawing.Point(525, 53)
        Me.total_mov_debe.Name = "total_mov_debe"
        Me.total_mov_debe.ReadOnly = True
        Me.total_mov_debe.Size = New System.Drawing.Size(86, 21)
        Me.total_mov_debe.TabIndex = 70
        Me.total_mov_debe.Text = "0.00"
        Me.total_mov_debe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frm_CO_RP_BalCompro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1326, 553)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dgv_detalle)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv_movimiento_cuenta)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_RP_BalCompro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance de Comprobacion"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgv_movimiento_cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents chk_solo_ctas_tit As System.Windows.Forms.CheckBox
    Private WithEvents chk_con_cta_tit As System.Windows.Forms.CheckBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rb_acumulado As System.Windows.Forms.RadioButton
    Private WithEvents rb_mensual As System.Windows.Forms.RadioButton
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Private WithEvents mtb_ayo As System.Windows.Forms.MaskedTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents cmb_Moneda As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents btn_consultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents inv_activo_3 As System.Windows.Forms.MaskedTextBox
    Private WithEvents inv_pasivo_3 As System.Windows.Forms.MaskedTextBox
    Private WithEvents natu_ganancia_3 As System.Windows.Forms.MaskedTextBox
    Private WithEvents fun_perdida_3 As System.Windows.Forms.MaskedTextBox
    Private WithEvents fun_ganancia_3 As System.Windows.Forms.MaskedTextBox
    Private WithEvents natu_perdida_3 As System.Windows.Forms.MaskedTextBox
    Private WithEvents inv_activo_2 As System.Windows.Forms.MaskedTextBox
    Private WithEvents inv_pasivo_2 As System.Windows.Forms.MaskedTextBox
    Private WithEvents natu_ganancia_2 As System.Windows.Forms.MaskedTextBox
    Private WithEvents fun_perdida_2 As System.Windows.Forms.MaskedTextBox
    Private WithEvents fun_ganancia_2 As System.Windows.Forms.MaskedTextBox
    Private WithEvents natu_perdida_2 As System.Windows.Forms.MaskedTextBox
    Private WithEvents saldo_acreedor As System.Windows.Forms.MaskedTextBox
    Private WithEvents inv_activo As System.Windows.Forms.MaskedTextBox
    Private WithEvents inv_pasivo As System.Windows.Forms.MaskedTextBox
    Private WithEvents saldo_deudor As System.Windows.Forms.MaskedTextBox
    Private WithEvents natu_ganancia As System.Windows.Forms.MaskedTextBox
    Private WithEvents fun_perdida As System.Windows.Forms.MaskedTextBox
    Private WithEvents fun_ganancia As System.Windows.Forms.MaskedTextBox
    Private WithEvents natu_perdida As System.Windows.Forms.MaskedTextBox
    Private WithEvents si_credito As System.Windows.Forms.MaskedTextBox
    Private WithEvents mov_debito As System.Windows.Forms.MaskedTextBox
    Private WithEvents mov_credito As System.Windows.Forms.MaskedTextBox
    Private WithEvents si_debito As System.Windows.Forms.MaskedTextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_movimiento_cuenta As System.Windows.Forms.DataGridView
    Friend WithEvents btn_regresar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents total_cuenta_haber As System.Windows.Forms.MaskedTextBox
    Private WithEvents total_cuenta_debe As System.Windows.Forms.MaskedTextBox
    Private WithEvents total_mov_haber As System.Windows.Forms.MaskedTextBox
    Private WithEvents total_mov_debe As System.Windows.Forms.MaskedTextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents txt_total_monto_original As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_actualizar As System.Windows.Forms.ToolStripButton
End Class
