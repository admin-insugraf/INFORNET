<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_RP_BalInven
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_RP_BalInven))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdb_detallado = New System.Windows.Forms.RadioButton()
        Me.rdb_resumido = New System.Windows.Forms.RadioButton()
        Me.mtb_ayo = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb59 = New System.Windows.Forms.RadioButton()
        Me.rb45 = New System.Windows.Forms.RadioButton()
        Me.rb44 = New System.Windows.Forms.RadioButton()
        Me.rb40 = New System.Windows.Forms.RadioButton()
        Me.rb39 = New System.Windows.Forms.RadioButton()
        Me.rb37 = New System.Windows.Forms.RadioButton()
        Me.rb33 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rb50 = New System.Windows.Forms.RadioButton()
        Me.rb49 = New System.Windows.Forms.RadioButton()
        Me.rb46 = New System.Windows.Forms.RadioButton()
        Me.rb42 = New System.Windows.Forms.RadioButton()
        Me.rb41 = New System.Windows.Forms.RadioButton()
        Me.rb34 = New System.Windows.Forms.RadioButton()
        Me.rb31 = New System.Windows.Forms.RadioButton()
        Me.rb20 = New System.Windows.Forms.RadioButton()
        Me.rb19 = New System.Windows.Forms.RadioButton()
        Me.rb16 = New System.Windows.Forms.RadioButton()
        Me.rb14 = New System.Windows.Forms.RadioButton()
        Me.rb12 = New System.Windows.Forms.RadioButton()
        Me.rb10 = New System.Windows.Forms.RadioButton()
        Me.rb52 = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(909, 25)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = CType(resources.GetObject("Tool_imprimir.Image"), System.Drawing.Image)
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(78, 22)
        Me.Tool_imprimir.Text = "Consultar"
        Me.Tool_imprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.rdb_detallado)
        Me.groupBox2.Controls.Add(Me.rdb_resumido)
        Me.groupBox2.Controls.Add(Me.mtb_ayo)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.ForeColor = System.Drawing.Color.Navy
        Me.groupBox2.Location = New System.Drawing.Point(12, 27)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(322, 41)
        Me.groupBox2.TabIndex = 21
        Me.groupBox2.TabStop = False
        '
        'rdb_detallado
        '
        Me.rdb_detallado.AutoSize = True
        Me.rdb_detallado.Location = New System.Drawing.Point(225, 13)
        Me.rdb_detallado.Name = "rdb_detallado"
        Me.rdb_detallado.Size = New System.Drawing.Size(70, 17)
        Me.rdb_detallado.TabIndex = 8
        Me.rdb_detallado.Text = "Detallado"
        Me.rdb_detallado.UseVisualStyleBackColor = True
        '
        'rdb_resumido
        '
        Me.rdb_resumido.AutoSize = True
        Me.rdb_resumido.Checked = True
        Me.rdb_resumido.Location = New System.Drawing.Point(144, 13)
        Me.rdb_resumido.Name = "rdb_resumido"
        Me.rdb_resumido.Size = New System.Drawing.Size(72, 17)
        Me.rdb_resumido.TabIndex = 7
        Me.rdb_resumido.TabStop = True
        Me.rdb_resumido.Text = "Resumido"
        Me.rdb_resumido.UseVisualStyleBackColor = True
        '
        'mtb_ayo
        '
        Me.mtb_ayo.Location = New System.Drawing.Point(61, 12)
        Me.mtb_ayo.Mask = "9999"
        Me.mtb_ayo.Name = "mtb_ayo"
        Me.mtb_ayo.Size = New System.Drawing.Size(42, 20)
        Me.mtb_ayo.TabIndex = 4
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Periodo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dgv_detalle)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(350, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(551, 556)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'dgv_detalle
        '
        Me.dgv_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Location = New System.Drawing.Point(13, 19)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.Size = New System.Drawing.Size(527, 525)
        Me.dgv_detalle.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.rb52)
        Me.groupBox1.Controls.Add(Me.rb59)
        Me.groupBox1.Controls.Add(Me.rb45)
        Me.groupBox1.Controls.Add(Me.rb44)
        Me.groupBox1.Controls.Add(Me.rb40)
        Me.groupBox1.Controls.Add(Me.rb39)
        Me.groupBox1.Controls.Add(Me.rb37)
        Me.groupBox1.Controls.Add(Me.rb33)
        Me.groupBox1.Controls.Add(Me.RadioButton2)
        Me.groupBox1.Controls.Add(Me.RadioButton1)
        Me.groupBox1.Controls.Add(Me.rb50)
        Me.groupBox1.Controls.Add(Me.rb49)
        Me.groupBox1.Controls.Add(Me.rb46)
        Me.groupBox1.Controls.Add(Me.rb42)
        Me.groupBox1.Controls.Add(Me.rb41)
        Me.groupBox1.Controls.Add(Me.rb34)
        Me.groupBox1.Controls.Add(Me.rb31)
        Me.groupBox1.Controls.Add(Me.rb20)
        Me.groupBox1.Controls.Add(Me.rb19)
        Me.groupBox1.Controls.Add(Me.rb16)
        Me.groupBox1.Controls.Add(Me.rb14)
        Me.groupBox1.Controls.Add(Me.rb12)
        Me.groupBox1.Controls.Add(Me.rb10)
        Me.groupBox1.ForeColor = System.Drawing.Color.Navy
        Me.groupBox1.Location = New System.Drawing.Point(12, 71)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(322, 556)
        Me.groupBox1.TabIndex = 25
        Me.groupBox1.TabStop = False
        '
        'rb59
        '
        Me.rb59.AutoSize = True
        Me.rb59.Location = New System.Drawing.Point(18, 527)
        Me.rb59.Name = "rb59"
        Me.rb59.Size = New System.Drawing.Size(160, 17)
        Me.rb59.TabIndex = 9
        Me.rb59.Text = "59 - Resultados Acumulados"
        Me.rb59.UseVisualStyleBackColor = True
        '
        'rb45
        '
        Me.rb45.AutoSize = True
        Me.rb45.Location = New System.Drawing.Point(18, 409)
        Me.rb45.Name = "rb45"
        Me.rb45.Size = New System.Drawing.Size(164, 17)
        Me.rb45.TabIndex = 8
        Me.rb45.Text = "45 - Obligaciones Financieras"
        Me.rb45.UseVisualStyleBackColor = True
        '
        'rb44
        '
        Me.rb44.AutoSize = True
        Me.rb44.Location = New System.Drawing.Point(18, 386)
        Me.rb44.Name = "rb44"
        Me.rb44.Size = New System.Drawing.Size(214, 17)
        Me.rb44.TabIndex = 7
        Me.rb44.Text = "44 - Ctas. x Pagar Accion. , Direc. , Ger."
        Me.rb44.UseVisualStyleBackColor = True
        '
        'rb40
        '
        Me.rb40.AutoSize = True
        Me.rb40.Location = New System.Drawing.Point(18, 317)
        Me.rb40.Name = "rb40"
        Me.rb40.Size = New System.Drawing.Size(191, 17)
        Me.rb40.TabIndex = 6
        Me.rb40.Text = "40 - Trib. y Aportes al S.P. y de SA."
        Me.rb40.UseVisualStyleBackColor = True
        '
        'rb39
        '
        Me.rb39.AutoSize = True
        Me.rb39.Location = New System.Drawing.Point(18, 294)
        Me.rb39.Name = "rb39"
        Me.rb39.Size = New System.Drawing.Size(223, 17)
        Me.rb39.TabIndex = 5
        Me.rb39.Text = "39 - Deprec. Amort. y Agotam. Acumulada"
        Me.rb39.UseVisualStyleBackColor = True
        '
        'rb37
        '
        Me.rb37.AutoSize = True
        Me.rb37.Location = New System.Drawing.Point(18, 272)
        Me.rb37.Name = "rb37"
        Me.rb37.Size = New System.Drawing.Size(115, 17)
        Me.rb37.TabIndex = 4
        Me.rb37.Text = "37 - Activo Diferido"
        Me.rb37.UseVisualStyleBackColor = True
        '
        'rb33
        '
        Me.rb33.AutoSize = True
        Me.rb33.Location = New System.Drawing.Point(18, 226)
        Me.rb33.Name = "rb33"
        Me.rb33.Size = New System.Drawing.Size(201, 17)
        Me.rb33.TabIndex = 3
        Me.rb33.Text = "33 - Inmuebles, Maquinaria y Equipos"
        Me.rb33.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(18, 180)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(196, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "25 - Mat. Auxiliar, Suministros y Rep."
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(18, 157)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(120, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "24 - Materias Primas"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rb50
        '
        Me.rb50.AutoSize = True
        Me.rb50.Location = New System.Drawing.Point(18, 478)
        Me.rb50.Name = "rb50"
        Me.rb50.Size = New System.Drawing.Size(78, 17)
        Me.rb50.TabIndex = 0
        Me.rb50.Text = "50 - Capital"
        Me.rb50.UseVisualStyleBackColor = True
        '
        'rb49
        '
        Me.rb49.AutoSize = True
        Me.rb49.Location = New System.Drawing.Point(18, 455)
        Me.rb49.Name = "rb49"
        Me.rb49.Size = New System.Drawing.Size(141, 17)
        Me.rb49.TabIndex = 0
        Me.rb49.Text = "49 - Ganancias Diferidas"
        Me.rb49.UseVisualStyleBackColor = True
        '
        'rb46
        '
        Me.rb46.AutoSize = True
        Me.rb46.Location = New System.Drawing.Point(18, 432)
        Me.rb46.Name = "rb46"
        Me.rb46.Size = New System.Drawing.Size(178, 17)
        Me.rb46.TabIndex = 0
        Me.rb46.Text = "46 - Cuentas por Pagar Diversas"
        Me.rb46.UseVisualStyleBackColor = True
        '
        'rb42
        '
        Me.rb42.AutoSize = True
        Me.rb42.Location = New System.Drawing.Point(18, 363)
        Me.rb42.Name = "rb42"
        Me.rb42.Size = New System.Drawing.Size(106, 17)
        Me.rb42.TabIndex = 0
        Me.rb42.Text = "42 - Proveedores"
        Me.rb42.UseVisualStyleBackColor = True
        '
        'rb41
        '
        Me.rb41.AutoSize = True
        Me.rb41.Location = New System.Drawing.Point(18, 340)
        Me.rb41.Name = "rb41"
        Me.rb41.Size = New System.Drawing.Size(175, 17)
        Me.rb41.TabIndex = 0
        Me.rb41.Text = "41 - Remuneraciones por Pagar"
        Me.rb41.UseVisualStyleBackColor = True
        '
        'rb34
        '
        Me.rb34.AutoSize = True
        Me.rb34.Location = New System.Drawing.Point(18, 249)
        Me.rb34.Name = "rb34"
        Me.rb34.Size = New System.Drawing.Size(97, 17)
        Me.rb34.TabIndex = 0
        Me.rb34.Text = "34 - Intangibles"
        Me.rb34.UseVisualStyleBackColor = True
        '
        'rb31
        '
        Me.rb31.AutoSize = True
        Me.rb31.Location = New System.Drawing.Point(18, 203)
        Me.rb31.Name = "rb31"
        Me.rb31.Size = New System.Drawing.Size(81, 17)
        Me.rb31.TabIndex = 0
        Me.rb31.Text = "31 - Valores"
        Me.rb31.UseVisualStyleBackColor = True
        '
        'rb20
        '
        Me.rb20.AutoSize = True
        Me.rb20.Location = New System.Drawing.Point(18, 134)
        Me.rb20.Name = "rb20"
        Me.rb20.Size = New System.Drawing.Size(274, 17)
        Me.rb20.TabIndex = 0
        Me.rb20.Text = "20 - Mercaderia y la cuenta 21 Productos terminados"
        Me.rb20.UseVisualStyleBackColor = True
        '
        'rb19
        '
        Me.rb19.AutoSize = True
        Me.rb19.Location = New System.Drawing.Point(18, 111)
        Me.rb19.Name = "rb19"
        Me.rb19.Size = New System.Drawing.Size(200, 17)
        Me.rb19.TabIndex = 0
        Me.rb19.Text = "19 - Provision para Cuentas Dudosas"
        Me.rb19.UseVisualStyleBackColor = True
        '
        'rb16
        '
        Me.rb16.AutoSize = True
        Me.rb16.Location = New System.Drawing.Point(18, 88)
        Me.rb16.Name = "rb16"
        Me.rb16.Size = New System.Drawing.Size(181, 17)
        Me.rb16.TabIndex = 0
        Me.rb16.Text = "16 - Cuentas por Cobrar Diversas"
        Me.rb16.UseVisualStyleBackColor = True
        '
        'rb14
        '
        Me.rb14.AutoSize = True
        Me.rb14.Location = New System.Drawing.Point(18, 65)
        Me.rb14.Name = "rb14"
        Me.rb14.Size = New System.Drawing.Size(194, 17)
        Me.rb14.TabIndex = 0
        Me.rb14.Text = "14 - Cuentas por Cobrar Accionistas"
        Me.rb14.UseVisualStyleBackColor = True
        '
        'rb12
        '
        Me.rb12.AutoSize = True
        Me.rb12.Location = New System.Drawing.Point(18, 42)
        Me.rb12.Name = "rb12"
        Me.rb12.Size = New System.Drawing.Size(83, 17)
        Me.rb12.TabIndex = 0
        Me.rb12.Text = "12 - Clientes"
        Me.rb12.UseVisualStyleBackColor = True
        '
        'rb10
        '
        Me.rb10.AutoSize = True
        Me.rb10.Checked = True
        Me.rb10.Location = New System.Drawing.Point(18, 19)
        Me.rb10.Name = "rb10"
        Me.rb10.Size = New System.Drawing.Size(114, 17)
        Me.rb10.TabIndex = 0
        Me.rb10.TabStop = True
        Me.rb10.Text = "10 - Caja y Bancos"
        Me.rb10.UseVisualStyleBackColor = True
        '
        'rb52
        '
        Me.rb52.AutoSize = True
        Me.rb52.Location = New System.Drawing.Point(18, 504)
        Me.rb52.Name = "rb52"
        Me.rb52.Size = New System.Drawing.Size(124, 17)
        Me.rb52.TabIndex = 10
        Me.rb52.Text = "52 - Capital Adicional"
        Me.rb52.UseVisualStyleBackColor = True
        '
        'frm_CO_RP_BalInven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 634)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_CO_RP_BalInven"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance e Inventarios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents mtb_ayo As System.Windows.Forms.MaskedTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents rdb_detallado As System.Windows.Forms.RadioButton
    Private WithEvents rdb_resumido As System.Windows.Forms.RadioButton
    Private WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rb59 As System.Windows.Forms.RadioButton
    Private WithEvents rb45 As System.Windows.Forms.RadioButton
    Private WithEvents rb44 As System.Windows.Forms.RadioButton
    Private WithEvents rb40 As System.Windows.Forms.RadioButton
    Private WithEvents rb39 As System.Windows.Forms.RadioButton
    Private WithEvents rb37 As System.Windows.Forms.RadioButton
    Private WithEvents rb33 As System.Windows.Forms.RadioButton
    Private WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Private WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents rb50 As System.Windows.Forms.RadioButton
    Private WithEvents rb49 As System.Windows.Forms.RadioButton
    Private WithEvents rb46 As System.Windows.Forms.RadioButton
    Private WithEvents rb42 As System.Windows.Forms.RadioButton
    Private WithEvents rb41 As System.Windows.Forms.RadioButton
    Private WithEvents rb34 As System.Windows.Forms.RadioButton
    Private WithEvents rb31 As System.Windows.Forms.RadioButton
    Private WithEvents rb20 As System.Windows.Forms.RadioButton
    Private WithEvents rb19 As System.Windows.Forms.RadioButton
    Private WithEvents rb16 As System.Windows.Forms.RadioButton
    Private WithEvents rb14 As System.Windows.Forms.RadioButton
    Private WithEvents rb12 As System.Windows.Forms.RadioButton
    Private WithEvents rb10 As System.Windows.Forms.RadioButton
    Private WithEvents rb52 As System.Windows.Forms.RadioButton
End Class
