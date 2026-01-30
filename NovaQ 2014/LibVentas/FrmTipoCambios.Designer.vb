<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoCambios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoCambios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDetallesTipoC = New System.Windows.Forms.DataGridView()
        Me.gbFiltroTipoCambio = New System.Windows.Forms.GroupBox()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbMesProceso = New System.Windows.Forms.RadioButton()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.dtpFechaDia = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaMes = New System.Windows.Forms.DateTimePicker()
        Me.gbGenerarTipoCambio = New System.Windows.Forms.GroupBox()
        Me.txtTipoCompra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTipoVenta = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetallesTipoC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltroTipoCambio.SuspendLayout()
        Me.gbGenerarTipoCambio.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvDetallesTipoC)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 337)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'dgvDetallesTipoC
        '
        Me.dgvDetallesTipoC.AllowUserToAddRows = False
        Me.dgvDetallesTipoC.AllowUserToDeleteRows = False
        Me.dgvDetallesTipoC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvDetallesTipoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallesTipoC.Location = New System.Drawing.Point(8, 19)
        Me.dgvDetallesTipoC.Name = "dgvDetallesTipoC"
        Me.dgvDetallesTipoC.ReadOnly = True
        Me.dgvDetallesTipoC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetallesTipoC.Size = New System.Drawing.Size(370, 312)
        Me.dgvDetallesTipoC.TabIndex = 0
        '
        'gbFiltroTipoCambio
        '
        Me.gbFiltroTipoCambio.BackColor = System.Drawing.Color.White
        Me.gbFiltroTipoCambio.Controls.Add(Me.rbFecha)
        Me.gbFiltroTipoCambio.Controls.Add(Me.rbMesProceso)
        Me.gbFiltroTipoCambio.Controls.Add(Me.btnRefrescar)
        Me.gbFiltroTipoCambio.Controls.Add(Me.dtpFechaDia)
        Me.gbFiltroTipoCambio.Controls.Add(Me.dtpFechaMes)
        Me.gbFiltroTipoCambio.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbFiltroTipoCambio.ForeColor = System.Drawing.Color.Navy
        Me.gbFiltroTipoCambio.Location = New System.Drawing.Point(10, 30)
        Me.gbFiltroTipoCambio.Name = "gbFiltroTipoCambio"
        Me.gbFiltroTipoCambio.Size = New System.Drawing.Size(384, 73)
        Me.gbFiltroTipoCambio.TabIndex = 121
        Me.gbFiltroTipoCambio.TabStop = False
        Me.gbFiltroTipoCambio.Text = "&Tipo de Cambio"
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbFecha.ForeColor = System.Drawing.Color.Navy
        Me.rbFecha.Location = New System.Drawing.Point(24, 51)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(74, 17)
        Me.rbFecha.TabIndex = 165
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "&Fecha Dia"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'rbMesProceso
        '
        Me.rbMesProceso.AutoSize = True
        Me.rbMesProceso.Checked = True
        Me.rbMesProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbMesProceso.ForeColor = System.Drawing.Color.Navy
        Me.rbMesProceso.Location = New System.Drawing.Point(25, 26)
        Me.rbMesProceso.Name = "rbMesProceso"
        Me.rbMesProceso.Size = New System.Drawing.Size(78, 17)
        Me.rbMesProceso.TabIndex = 164
        Me.rbMesProceso.TabStop = True
        Me.rbMesProceso.Text = "&Fecha Mes"
        Me.rbMesProceso.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefrescar.Location = New System.Drawing.Point(266, 22)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(100, 26)
        Me.btnRefrescar.TabIndex = 125
        Me.btnRefrescar.Text = "&Mostrar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'dtpFechaDia
        '
        Me.dtpFechaDia.CustomFormat = ""
        Me.dtpFechaDia.Enabled = False
        Me.dtpFechaDia.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDia.Location = New System.Drawing.Point(105, 47)
        Me.dtpFechaDia.Name = "dtpFechaDia"
        Me.dtpFechaDia.Size = New System.Drawing.Size(154, 22)
        Me.dtpFechaDia.TabIndex = 123
        '
        'dtpFechaMes
        '
        Me.dtpFechaMes.CustomFormat = "MMMM -     yyyy"
        Me.dtpFechaMes.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaMes.Location = New System.Drawing.Point(105, 23)
        Me.dtpFechaMes.Name = "dtpFechaMes"
        Me.dtpFechaMes.Size = New System.Drawing.Size(154, 22)
        Me.dtpFechaMes.TabIndex = 123
        '
        'gbGenerarTipoCambio
        '
        Me.gbGenerarTipoCambio.BackColor = System.Drawing.Color.White
        Me.gbGenerarTipoCambio.Controls.Add(Me.txtTipoCompra)
        Me.gbGenerarTipoCambio.Controls.Add(Me.Label5)
        Me.gbGenerarTipoCambio.Controls.Add(Me.txtTipoVenta)
        Me.gbGenerarTipoCambio.Controls.Add(Me.dtpFecha)
        Me.gbGenerarTipoCambio.Controls.Add(Me.Label4)
        Me.gbGenerarTipoCambio.Controls.Add(Me.Label1)
        Me.gbGenerarTipoCambio.Controls.Add(Me.txtMoneda)
        Me.gbGenerarTipoCambio.Controls.Add(Me.Label3)
        Me.gbGenerarTipoCambio.Controls.Add(Me.TextBox1)
        Me.gbGenerarTipoCambio.Location = New System.Drawing.Point(11, 30)
        Me.gbGenerarTipoCambio.Name = "gbGenerarTipoCambio"
        Me.gbGenerarTipoCambio.Size = New System.Drawing.Size(377, 72)
        Me.gbGenerarTipoCambio.TabIndex = 163
        Me.gbGenerarTipoCambio.TabStop = False
        Me.gbGenerarTipoCambio.Visible = False
        '
        'txtTipoCompra
        '
        Me.txtTipoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCompra.Location = New System.Drawing.Point(195, 46)
        Me.txtTipoCompra.Name = "txtTipoCompra"
        Me.txtTipoCompra.Size = New System.Drawing.Size(84, 20)
        Me.txtTipoCompra.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(193, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "Tipo de Compra"
        '
        'txtTipoVenta
        '
        Me.txtTipoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoVenta.Location = New System.Drawing.Point(285, 47)
        Me.txtTipoVenta.Name = "txtTipoVenta"
        Me.txtTipoVenta.Size = New System.Drawing.Size(84, 20)
        Me.txtTipoVenta.TabIndex = 4
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(89, 46)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(99, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(283, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Tipo de Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(88, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Fecha"
        '
        'txtMoneda
        '
        Me.txtMoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMoneda.Enabled = False
        Me.txtMoneda.Location = New System.Drawing.Point(22, 46)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(61, 20)
        Me.txtMoneda.TabIndex = 1
        Me.txtMoneda.Text = "ME"
        Me.txtMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(20, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Moneda"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(0, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 22)
        Me.TextBox1.TabIndex = 164
        Me.TextBox1.Text = "TIPO DE CAMBIO"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_cancelar, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(405, 25)
        Me.ToolStrip1.TabIndex = 164
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
        Me.btn_grabar.Size = New System.Drawing.Size(62, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_Editar
        '
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(78, 22)
        Me.btn_Editar.Text = "&Modificar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(73, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton5.Text = "&Salir"
        '
        'FrmTipoCambios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(405, 445)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbFiltroTipoCambio)
        Me.Controls.Add(Me.gbGenerarTipoCambio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTipoCambios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Cambio"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDetallesTipoC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltroTipoCambio.ResumeLayout(False)
        Me.gbFiltroTipoCambio.PerformLayout()
        Me.gbGenerarTipoCambio.ResumeLayout(False)
        Me.gbGenerarTipoCambio.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbFiltroTipoCambio As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaMes As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbGenerarTipoCambio As System.Windows.Forms.GroupBox
    Friend WithEvents txtTipoCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTipoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetallesTipoC As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFechaDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbMesProceso As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
End Class
