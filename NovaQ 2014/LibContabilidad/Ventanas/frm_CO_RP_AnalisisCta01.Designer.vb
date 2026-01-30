<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CO_RP_AnalisisCta01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CO_RP_AnalisisCta01))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.chk_SoloPen = New System.Windows.Forms.CheckBox()
        Me.chk_Resumen = New System.Windows.Forms.CheckBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtDescripcionTercero1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtTerceroIni = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txtTerceroFin = New System.Windows.Forms.TextBox()
        Me.txtDescripcionTercero2 = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtDescripcionCuenta1 = New System.Windows.Forms.TextBox()
        Me.txtCuentaContableInicial = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.txtDescripcionCuenta2 = New System.Windows.Forms.TextBox()
        Me.txtCuentaContableFinal = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtb_fec_has = New System.Windows.Forms.MaskedTextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.mtb_fec_des = New System.Windows.Forms.MaskedTextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(614, 25)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = CType(resources.GetObject("Tool_imprimir.Image"), System.Drawing.Image)
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(118, 22)
        Me.Tool_imprimir.Text = "&Mostrar reporte"
        Me.Tool_imprimir.ToolTipText = "&Imprimir"
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
        Me.Tool_salir.Size = New System.Drawing.Size(52, 22)
        Me.Tool_salir.Text = "&Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.chk_SoloPen)
        Me.groupBox4.Controls.Add(Me.chk_Resumen)
        Me.groupBox4.ForeColor = System.Drawing.Color.Navy
        Me.groupBox4.Location = New System.Drawing.Point(477, 28)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(129, 159)
        Me.groupBox4.TabIndex = 26
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Opciones"
        '
        'chk_SoloPen
        '
        Me.chk_SoloPen.AutoSize = True
        Me.chk_SoloPen.Checked = True
        Me.chk_SoloPen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SoloPen.ForeColor = System.Drawing.Color.Navy
        Me.chk_SoloPen.Location = New System.Drawing.Point(18, 60)
        Me.chk_SoloPen.Name = "chk_SoloPen"
        Me.chk_SoloPen.Size = New System.Drawing.Size(103, 17)
        Me.chk_SoloPen.TabIndex = 8
        Me.chk_SoloPen.Text = "Solo Pendientes"
        Me.chk_SoloPen.UseVisualStyleBackColor = True
        '
        'chk_Resumen
        '
        Me.chk_Resumen.AutoSize = True
        Me.chk_Resumen.ForeColor = System.Drawing.Color.Navy
        Me.chk_Resumen.Location = New System.Drawing.Point(18, 33)
        Me.chk_Resumen.Name = "chk_Resumen"
        Me.chk_Resumen.Size = New System.Drawing.Size(71, 17)
        Me.chk_Resumen.TabIndex = 7
        Me.chk_Resumen.Text = "Resumen"
        Me.chk_Resumen.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Navy
        Me.label3.Location = New System.Drawing.Point(11, 100)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Anexo Fin"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Navy
        Me.label6.Location = New System.Drawing.Point(10, 74)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(51, 13)
        Me.label6.TabIndex = 15
        Me.label6.Text = "Anexo Ini"
        '
        'txtDescripcionTercero1
        '
        Me.txtDescripcionTercero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionTercero1.Location = New System.Drawing.Point(191, 67)
        Me.txtDescripcionTercero1.Name = "txtDescripcionTercero1"
        Me.txtDescripcionTercero1.ReadOnly = True
        Me.txtDescripcionTercero1.Size = New System.Drawing.Size(256, 20)
        Me.txtDescripcionTercero1.TabIndex = 100
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(171, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.TabIndex = 125
        Me.PictureBox2.TabStop = False
        '
        'txtTerceroIni
        '
        Me.txtTerceroIni.BackColor = System.Drawing.Color.Aquamarine
        Me.txtTerceroIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTerceroIni.Location = New System.Drawing.Point(72, 67)
        Me.txtTerceroIni.Name = "txtTerceroIni"
        Me.txtTerceroIni.ReadOnly = True
        Me.txtTerceroIni.Size = New System.Drawing.Size(97, 20)
        Me.txtTerceroIni.TabIndex = 5
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(171, 67)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox7.TabIndex = 122
        Me.PictureBox7.TabStop = False
        '
        'txtTerceroFin
        '
        Me.txtTerceroFin.BackColor = System.Drawing.Color.Aquamarine
        Me.txtTerceroFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTerceroFin.Location = New System.Drawing.Point(72, 93)
        Me.txtTerceroFin.Name = "txtTerceroFin"
        Me.txtTerceroFin.ReadOnly = True
        Me.txtTerceroFin.Size = New System.Drawing.Size(97, 20)
        Me.txtTerceroFin.TabIndex = 6
        '
        'txtDescripcionTercero2
        '
        Me.txtDescripcionTercero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionTercero2.Location = New System.Drawing.Point(191, 93)
        Me.txtDescripcionTercero2.Name = "txtDescripcionTercero2"
        Me.txtDescripcionTercero2.ReadOnly = True
        Me.txtDescripcionTercero2.Size = New System.Drawing.Size(256, 20)
        Me.txtDescripcionTercero2.TabIndex = 100
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.txtDescripcionCuenta1)
        Me.groupBox2.Controls.Add(Me.txtDescripcionTercero1)
        Me.groupBox2.Controls.Add(Me.txtCuentaContableInicial)
        Me.groupBox2.Controls.Add(Me.PictureBox6)
        Me.groupBox2.Controls.Add(Me.PictureBox2)
        Me.groupBox2.Controls.Add(Me.txtDescripcionCuenta2)
        Me.groupBox2.Controls.Add(Me.txtCuentaContableFinal)
        Me.groupBox2.Controls.Add(Me.txtTerceroIni)
        Me.groupBox2.Controls.Add(Me.PictureBox1)
        Me.groupBox2.Controls.Add(Me.PictureBox7)
        Me.groupBox2.Controls.Add(Me.txtDescripcionTercero2)
        Me.groupBox2.Controls.Add(Me.txtTerceroFin)
        Me.groupBox2.Location = New System.Drawing.Point(12, 70)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(459, 118)
        Me.groupBox2.TabIndex = 24
        Me.groupBox2.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.Navy
        Me.label1.Location = New System.Drawing.Point(11, 41)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Cuenta Fin"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Navy
        Me.label2.Location = New System.Drawing.Point(10, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(55, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Cuenta Ini"
        '
        'txtDescripcionCuenta1
        '
        Me.txtDescripcionCuenta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionCuenta1.Location = New System.Drawing.Point(191, 11)
        Me.txtDescripcionCuenta1.Name = "txtDescripcionCuenta1"
        Me.txtDescripcionCuenta1.ReadOnly = True
        Me.txtDescripcionCuenta1.Size = New System.Drawing.Size(256, 20)
        Me.txtDescripcionCuenta1.TabIndex = 100
        '
        'txtCuentaContableInicial
        '
        Me.txtCuentaContableInicial.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCuentaContableInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaContableInicial.Location = New System.Drawing.Point(72, 11)
        Me.txtCuentaContableInicial.Name = "txtCuentaContableInicial"
        Me.txtCuentaContableInicial.ReadOnly = True
        Me.txtCuentaContableInicial.Size = New System.Drawing.Size(97, 20)
        Me.txtCuentaContableInicial.TabIndex = 3
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(171, 12)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox6.TabIndex = 116
        Me.PictureBox6.TabStop = False
        '
        'txtDescripcionCuenta2
        '
        Me.txtDescripcionCuenta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionCuenta2.Location = New System.Drawing.Point(191, 37)
        Me.txtDescripcionCuenta2.Name = "txtDescripcionCuenta2"
        Me.txtDescripcionCuenta2.ReadOnly = True
        Me.txtDescripcionCuenta2.Size = New System.Drawing.Size(256, 20)
        Me.txtDescripcionCuenta2.TabIndex = 100
        '
        'txtCuentaContableFinal
        '
        Me.txtCuentaContableFinal.BackColor = System.Drawing.Color.Aquamarine
        Me.txtCuentaContableFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaContableFinal.Location = New System.Drawing.Point(72, 37)
        Me.txtCuentaContableFinal.Name = "txtCuentaContableFinal"
        Me.txtCuentaContableFinal.ReadOnly = True
        Me.txtCuentaContableFinal.Size = New System.Drawing.Size(97, 20)
        Me.txtCuentaContableFinal.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(171, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.mtb_fec_has)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.mtb_fec_des)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Location = New System.Drawing.Point(12, 28)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(459, 41)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        '
        'mtb_fec_has
        '
        Me.mtb_fec_has.Location = New System.Drawing.Point(252, 13)
        Me.mtb_fec_has.Mask = "00/00/0000"
        Me.mtb_fec_has.Name = "mtb_fec_has"
        Me.mtb_fec_has.Size = New System.Drawing.Size(73, 20)
        Me.mtb_fec_has.TabIndex = 2
        Me.mtb_fec_has.ValidatingType = GetType(Date)
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.Navy
        Me.label5.Location = New System.Drawing.Point(175, 16)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(68, 13)
        Me.label5.TabIndex = 16
        Me.label5.Text = "Fecha Hasta"
        '
        'mtb_fec_des
        '
        Me.mtb_fec_des.Location = New System.Drawing.Point(87, 13)
        Me.mtb_fec_des.Mask = "00/00/0000"
        Me.mtb_fec_des.Name = "mtb_fec_des"
        Me.mtb_fec_des.Size = New System.Drawing.Size(73, 20)
        Me.mtb_fec_des.TabIndex = 1
        Me.mtb_fec_des.ValidatingType = GetType(Date)
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Navy
        Me.label4.Location = New System.Drawing.Point(10, 16)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 13)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Fecha Desde"
        '
        'frm_CO_RP_AnalisisCta01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(614, 197)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_CO_RP_AnalisisCta01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analisis de Cuentas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents chk_SoloPen As System.Windows.Forms.CheckBox
    Private WithEvents chk_Resumen As System.Windows.Forms.CheckBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents mtb_fec_has As System.Windows.Forms.MaskedTextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents mtb_fec_des As System.Windows.Forms.MaskedTextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Private WithEvents txtCuentaContableInicial As System.Windows.Forms.TextBox
    Private WithEvents txtDescripcionCuenta1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents txtCuentaContableFinal As System.Windows.Forms.TextBox
    Private WithEvents txtDescripcionCuenta2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Private WithEvents txtDescripcionTercero1 As System.Windows.Forms.TextBox
    Private WithEvents txtTerceroIni As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents txtDescripcionTercero2 As System.Windows.Forms.TextBox
    Private WithEvents txtTerceroFin As System.Windows.Forms.TextBox
End Class
