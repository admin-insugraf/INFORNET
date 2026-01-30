<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AF_RP_deter_depreci
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AF_RP_deter_depreci))
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.tool_Ayuda2 = New System.Windows.Forms.ToolStripButton()
        Me.Tool_exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mtb_fec_proc = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_listado = New System.Windows.Forms.DataGridView()
        Me.btn_procesar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AC_IDACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDO_INICIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEJORAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FAMILIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TASA_DEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB1_AÑOS_A_DEPRECIAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB1_DEPRE_ANUAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB1_MESES_A_DEPRECIAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB1_DEPRE_MENSUAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB1_DEPRE_EJERCICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB2_AÑOS_TRANSCURRIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB2_MESES_TRANSCURRIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_LA_FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FA_CUENTA_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.LightGray
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool_Ayuda2, Me.Tool_exportar, Me.ToolStripSeparator7, Me.Tool_Salir, Me.ToolStripSeparator3})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(947, 25)
        Me.ToolS_Mantenimiento.TabIndex = 9
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
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
        'Tool_exportar
        '
        Me.Tool_exportar.ForeColor = System.Drawing.Color.Navy
        Me.Tool_exportar.Image = Global.LibActivo.My.Resources.Resources._16__Doc_excel_
        Me.Tool_exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_exportar.Name = "Tool_exportar"
        Me.Tool_exportar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_exportar.Text = "&Exportar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.ForeColor = System.Drawing.Color.Navy
        Me.Tool_Salir.Image = Global.LibActivo.My.Resources.Resources._16__Exit_
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "&Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'mtb_fec_proc
        '
        Me.mtb_fec_proc.Location = New System.Drawing.Point(92, 22)
        Me.mtb_fec_proc.Mask = "00/00/0000"
        Me.mtb_fec_proc.Name = "mtb_fec_proc"
        Me.mtb_fec_proc.Size = New System.Drawing.Size(91, 20)
        Me.mtb_fec_proc.TabIndex = 11
        Me.mtb_fec_proc.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha Proceso"
        '
        'dgv_listado
        '
        Me.dgv_listado.AllowUserToAddRows = False
        Me.dgv_listado.AllowUserToDeleteRows = False
        Me.dgv_listado.AllowUserToResizeColumns = False
        Me.dgv_listado.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_listado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AC_IDACTIVO, Me.ACTIVO, Me.FECHA, Me.SALDO_INICIAL, Me.MEJORAS, Me.FAMILIA, Me.TASA_DEP, Me.TB1_AÑOS_A_DEPRECIAR, Me.TB1_DEPRE_ANUAL, Me.TB1_MESES_A_DEPRECIAR, Me.TB1_DEPRE_MENSUAL, Me.TB1_DEPRE_EJERCICIO, Me.TB2_AÑOS_TRANSCURRIDOS, Me.TB2_MESES_TRANSCURRIDOS, Me.A_LA_FECHA, Me.FA_CUENTA_ACTIVO})
        Me.dgv_listado.Location = New System.Drawing.Point(12, 95)
        Me.dgv_listado.Name = "dgv_listado"
        Me.dgv_listado.ReadOnly = True
        Me.dgv_listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listado.Size = New System.Drawing.Size(920, 304)
        Me.dgv_listado.TabIndex = 12
        '
        'btn_procesar
        '
        Me.btn_procesar.Image = Global.LibActivo.My.Resources.Resources._16__Configure_
        Me.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_procesar.Location = New System.Drawing.Point(210, 19)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(107, 28)
        Me.btn_procesar.TabIndex = 13
        Me.btn_procesar.Text = "&Procesar"
        Me.btn_procesar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_procesar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mtb_fec_proc)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 61)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'AC_IDACTIVO
        '
        Me.AC_IDACTIVO.DataPropertyName = "AC_IDACTIVO"
        Me.AC_IDACTIVO.HeaderText = "COD. ACTIVO"
        Me.AC_IDACTIVO.Name = "AC_IDACTIVO"
        Me.AC_IDACTIVO.ReadOnly = True
        '
        'ACTIVO
        '
        Me.ACTIVO.DataPropertyName = "ACTIVO"
        Me.ACTIVO.HeaderText = "ACTIVO"
        Me.ACTIVO.Name = "ACTIVO"
        Me.ACTIVO.ReadOnly = True
        Me.ACTIVO.Width = 71
        '
        'FECHA
        '
        Me.FECHA.DataPropertyName = "FECHA"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FECHA.DefaultCellStyle = DataGridViewCellStyle2
        Me.FECHA.HeaderText = "FECHA OPERACIONES"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        Me.FECHA.Width = 134
        '
        'SALDO_INICIAL
        '
        Me.SALDO_INICIAL.DataPropertyName = "SALDO_INICIAL"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SALDO_INICIAL.DefaultCellStyle = DataGridViewCellStyle3
        Me.SALDO_INICIAL.HeaderText = "SALDO INICIAL"
        Me.SALDO_INICIAL.Name = "SALDO_INICIAL"
        Me.SALDO_INICIAL.ReadOnly = True
        Me.SALDO_INICIAL.Width = 99
        '
        'MEJORAS
        '
        Me.MEJORAS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MEJORAS.DataPropertyName = "MEJORAS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.MEJORAS.DefaultCellStyle = DataGridViewCellStyle4
        Me.MEJORAS.HeaderText = "MEJORAS"
        Me.MEJORAS.Name = "MEJORAS"
        Me.MEJORAS.ReadOnly = True
        Me.MEJORAS.Width = 83
        '
        'FAMILIA
        '
        Me.FAMILIA.DataPropertyName = "FAMILIA"
        Me.FAMILIA.HeaderText = "FAMILIA"
        Me.FAMILIA.Name = "FAMILIA"
        Me.FAMILIA.ReadOnly = True
        Me.FAMILIA.Width = 73
        '
        'TASA_DEP
        '
        Me.TASA_DEP.DataPropertyName = "TASA_DEP"
        Me.TASA_DEP.HeaderText = "TASA%"
        Me.TASA_DEP.Name = "TASA_DEP"
        Me.TASA_DEP.ReadOnly = True
        Me.TASA_DEP.Width = 68
        '
        'TB1_AÑOS_A_DEPRECIAR
        '
        Me.TB1_AÑOS_A_DEPRECIAR.DataPropertyName = "TB1_AÑOS_A_DEPRECIAR"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.TB1_AÑOS_A_DEPRECIAR.DefaultCellStyle = DataGridViewCellStyle5
        Me.TB1_AÑOS_A_DEPRECIAR.HeaderText = "AÑOS A DEPRECIAR"
        Me.TB1_AÑOS_A_DEPRECIAR.Name = "TB1_AÑOS_A_DEPRECIAR"
        Me.TB1_AÑOS_A_DEPRECIAR.ReadOnly = True
        Me.TB1_AÑOS_A_DEPRECIAR.Width = 125
        '
        'TB1_DEPRE_ANUAL
        '
        Me.TB1_DEPRE_ANUAL.DataPropertyName = "TB1_DEPRE_ANUAL"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.TB1_DEPRE_ANUAL.DefaultCellStyle = DataGridViewCellStyle6
        Me.TB1_DEPRE_ANUAL.HeaderText = "DEPREC. ANUAL"
        Me.TB1_DEPRE_ANUAL.Name = "TB1_DEPRE_ANUAL"
        Me.TB1_DEPRE_ANUAL.ReadOnly = True
        Me.TB1_DEPRE_ANUAL.Width = 108
        '
        'TB1_MESES_A_DEPRECIAR
        '
        Me.TB1_MESES_A_DEPRECIAR.DataPropertyName = "TB1_MESES_A_DEPRECIAR"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.TB1_MESES_A_DEPRECIAR.DefaultCellStyle = DataGridViewCellStyle7
        Me.TB1_MESES_A_DEPRECIAR.HeaderText = "MESES A DEPRECIAR"
        Me.TB1_MESES_A_DEPRECIAR.Name = "TB1_MESES_A_DEPRECIAR"
        Me.TB1_MESES_A_DEPRECIAR.ReadOnly = True
        Me.TB1_MESES_A_DEPRECIAR.Width = 132
        '
        'TB1_DEPRE_MENSUAL
        '
        Me.TB1_DEPRE_MENSUAL.DataPropertyName = "TB1_DEPRE_MENSUAL"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.TB1_DEPRE_MENSUAL.DefaultCellStyle = DataGridViewCellStyle8
        Me.TB1_DEPRE_MENSUAL.HeaderText = "DEPREC. MENSUAL"
        Me.TB1_DEPRE_MENSUAL.Name = "TB1_DEPRE_MENSUAL"
        Me.TB1_DEPRE_MENSUAL.ReadOnly = True
        Me.TB1_DEPRE_MENSUAL.Width = 123
        '
        'TB1_DEPRE_EJERCICIO
        '
        Me.TB1_DEPRE_EJERCICIO.DataPropertyName = "TB1_DEPRE_EJERCICIO"
        Me.TB1_DEPRE_EJERCICIO.HeaderText = "DEPREC. DEL EJERCICIO"
        Me.TB1_DEPRE_EJERCICIO.Name = "TB1_DEPRE_EJERCICIO"
        Me.TB1_DEPRE_EJERCICIO.ReadOnly = True
        Me.TB1_DEPRE_EJERCICIO.Width = 147
        '
        'TB2_AÑOS_TRANSCURRIDOS
        '
        Me.TB2_AÑOS_TRANSCURRIDOS.DataPropertyName = "TB2_AÑOS_TRANSCURRIDOS"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.TB2_AÑOS_TRANSCURRIDOS.DefaultCellStyle = DataGridViewCellStyle9
        Me.TB2_AÑOS_TRANSCURRIDOS.HeaderText = "AÑOS TRANSCURRIDOS"
        Me.TB2_AÑOS_TRANSCURRIDOS.Name = "TB2_AÑOS_TRANSCURRIDOS"
        Me.TB2_AÑOS_TRANSCURRIDOS.ReadOnly = True
        Me.TB2_AÑOS_TRANSCURRIDOS.Width = 145
        '
        'TB2_MESES_TRANSCURRIDOS
        '
        Me.TB2_MESES_TRANSCURRIDOS.DataPropertyName = "TB2_MESES_TRANSCURRIDOS"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.TB2_MESES_TRANSCURRIDOS.DefaultCellStyle = DataGridViewCellStyle10
        Me.TB2_MESES_TRANSCURRIDOS.HeaderText = "MESES TRANSCURRIDOS"
        Me.TB2_MESES_TRANSCURRIDOS.Name = "TB2_MESES_TRANSCURRIDOS"
        Me.TB2_MESES_TRANSCURRIDOS.ReadOnly = True
        Me.TB2_MESES_TRANSCURRIDOS.Width = 151
        '
        'A_LA_FECHA
        '
        Me.A_LA_FECHA.DataPropertyName = "A_LA_FECHA"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.A_LA_FECHA.DefaultCellStyle = DataGridViewCellStyle11
        Me.A_LA_FECHA.HeaderText = "ACUMULADO A LA FECHA"
        Me.A_LA_FECHA.Name = "A_LA_FECHA"
        Me.A_LA_FECHA.ReadOnly = True
        Me.A_LA_FECHA.Visible = False
        Me.A_LA_FECHA.Width = 104
        '
        'FA_CUENTA_ACTIVO
        '
        Me.FA_CUENTA_ACTIVO.DataPropertyName = "FA_CUENTA_ACTIVO"
        Me.FA_CUENTA_ACTIVO.HeaderText = "CUENTA CONTABLE"
        Me.FA_CUENTA_ACTIVO.Name = "FA_CUENTA_ACTIVO"
        Me.FA_CUENTA_ACTIVO.ReadOnly = True
        Me.FA_CUENTA_ACTIVO.Width = 124
        '
        'frm_AF_RP_deter_depreci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(947, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_listado)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AF_RP_deter_depreci"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Determinacion de la Depreciacion"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_Ayuda2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mtb_fec_proc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv_listado As System.Windows.Forms.DataGridView
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AC_IDACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALDO_INICIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEJORAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAMILIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TASA_DEP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TB1_AÑOS_A_DEPRECIAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TB1_DEPRE_ANUAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TB1_MESES_A_DEPRECIAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TB1_DEPRE_MENSUAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TB1_DEPRE_EJERCICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TB2_AÑOS_TRANSCURRIDOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TB2_MESES_TRANSCURRIDOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_LA_FECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FA_CUENTA_ACTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
