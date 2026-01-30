<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_LT_Proc_Depreciar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_LT_Proc_Depreciar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtb_fec_proc = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nud_anho = New System.Windows.Forms.NumericUpDown()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Procesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.pb_calculo = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nud_anho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtb_fec_proc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nud_anho)
        Me.GroupBox1.Controls.Add(Me.cmb_mes)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(521, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periodo"
        Me.GroupBox1.Visible = False
        '
        'mtb_fec_proc
        '
        Me.mtb_fec_proc.Location = New System.Drawing.Point(118, 99)
        Me.mtb_fec_proc.Mask = "00/00/0000"
        Me.mtb_fec_proc.Name = "mtb_fec_proc"
        Me.mtb_fec_proc.Size = New System.Drawing.Size(120, 20)
        Me.mtb_fec_proc.TabIndex = 5
        Me.mtb_fec_proc.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Proceso"
        '
        'nud_anho
        '
        Me.nud_anho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_anho.Location = New System.Drawing.Point(67, 23)
        Me.nud_anho.Maximum = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.nud_anho.Minimum = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.nud_anho.Name = "nud_anho"
        Me.nud_anho.Size = New System.Drawing.Size(171, 23)
        Me.nud_anho.TabIndex = 3
        Me.nud_anho.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'cmb_mes
        '
        Me.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(66, 56)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(172, 24)
        Me.cmb_mes.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.LightGray
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Procesar, Me.ToolStripSeparator1, Me.Tool_Salir, Me.tool_Ayuda2, Me.ToolStripSeparator7})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(321, 25)
        Me.ToolS_Mantenimiento.TabIndex = 9
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Procesar
        '
        Me.Tool_Procesar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Procesar.Image = Global.LibActivo.My.Resources.Resources._16__Configure_
        Me.Tool_Procesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Procesar.Name = "Tool_Procesar"
        Me.Tool_Procesar.Size = New System.Drawing.Size(77, 22)
        Me.Tool_Procesar.Text = "Procesar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'pb_calculo
        '
        Me.pb_calculo.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.pb_calculo.Location = New System.Drawing.Point(12, 84)
        Me.pb_calculo.Name = "pb_calculo"
        Me.pb_calculo.Size = New System.Drawing.Size(295, 23)
        Me.pb_calculo.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Procesar calculo de Depreciacion"
        '
        'frm_AF_LT_Proc_Depreciar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 122)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pb_calculo)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_AF_LT_Proc_Depreciar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calc. Depreciacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nud_anho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nud_anho As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Procesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pb_calculo As System.Windows.Forms.ProgressBar
    Friend WithEvents mtb_fec_proc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
