<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProCierreVentasMensual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProCierreVentasMensual))
        Me.gbFiltroTipoCambio = New System.Windows.Forms.GroupBox()
        Me.rbFechaMes = New System.Windows.Forms.RadioButton()
        Me.rbFechaAnno = New System.Windows.Forms.RadioButton()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.dtpFechaDia = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaMes = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDetallesTipoC = New System.Windows.Forms.DataGridView()
        Me.gbGenerarTipoCambio = New System.Windows.Forms.GroupBox()
        Me.dtpFechacierre = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipoCompra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTipoVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.gbFiltroTipoCambio.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetallesTipoC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGenerarTipoCambio.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbFiltroTipoCambio
        '
        Me.gbFiltroTipoCambio.BackColor = System.Drawing.Color.Transparent
        Me.gbFiltroTipoCambio.Controls.Add(Me.rbFechaMes)
        Me.gbFiltroTipoCambio.Controls.Add(Me.rbFechaAnno)
        Me.gbFiltroTipoCambio.Controls.Add(Me.btnRefrescar)
        Me.gbFiltroTipoCambio.Controls.Add(Me.dtpFechaDia)
        Me.gbFiltroTipoCambio.Controls.Add(Me.dtpFechaMes)
        Me.gbFiltroTipoCambio.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbFiltroTipoCambio.Location = New System.Drawing.Point(14, 32)
        Me.gbFiltroTipoCambio.Name = "gbFiltroTipoCambio"
        Me.gbFiltroTipoCambio.Size = New System.Drawing.Size(389, 76)
        Me.gbFiltroTipoCambio.TabIndex = 128
        Me.gbFiltroTipoCambio.TabStop = False
        Me.gbFiltroTipoCambio.Text = "Datos "
        '
        'rbFechaMes
        '
        Me.rbFechaMes.AutoSize = True
        Me.rbFechaMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbFechaMes.Location = New System.Drawing.Point(24, 51)
        Me.rbFechaMes.Name = "rbFechaMes"
        Me.rbFechaMes.Size = New System.Drawing.Size(78, 17)
        Me.rbFechaMes.TabIndex = 165
        Me.rbFechaMes.TabStop = True
        Me.rbFechaMes.Text = "&Fecha Mes"
        Me.rbFechaMes.UseVisualStyleBackColor = True
        '
        'rbFechaAnno
        '
        Me.rbFechaAnno.AutoSize = True
        Me.rbFechaAnno.Checked = True
        Me.rbFechaAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbFechaAnno.Location = New System.Drawing.Point(25, 26)
        Me.rbFechaAnno.Name = "rbFechaAnno"
        Me.rbFechaAnno.Size = New System.Drawing.Size(77, 17)
        Me.rbFechaAnno.TabIndex = 164
        Me.rbFechaAnno.TabStop = True
        Me.rbFechaAnno.Text = "&Fecha Año"
        Me.rbFechaAnno.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefrescar.Location = New System.Drawing.Point(266, 28)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(98, 39)
        Me.btnRefrescar.TabIndex = 125
        Me.btnRefrescar.Text = "&Mostrar"
        Me.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'dtpFechaDia
        '
        Me.dtpFechaDia.CustomFormat = "MMMM -   yyyy"
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
        Me.dtpFechaMes.CustomFormat = "                   yyyy"
        Me.dtpFechaMes.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtpFechaMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaMes.Location = New System.Drawing.Point(105, 23)
        Me.dtpFechaMes.Name = "dtpFechaMes"
        Me.dtpFechaMes.Size = New System.Drawing.Size(154, 22)
        Me.dtpFechaMes.TabIndex = 123
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDetallesTipoC)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 337)
        Me.GroupBox1.TabIndex = 127
        Me.GroupBox1.TabStop = False
        '
        'dgvDetallesTipoC
        '
        Me.dgvDetallesTipoC.AllowUserToAddRows = False
        Me.dgvDetallesTipoC.AllowUserToDeleteRows = False
        Me.dgvDetallesTipoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallesTipoC.Location = New System.Drawing.Point(12, 13)
        Me.dgvDetallesTipoC.Name = "dgvDetallesTipoC"
        Me.dgvDetallesTipoC.ReadOnly = True
        Me.dgvDetallesTipoC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetallesTipoC.Size = New System.Drawing.Size(370, 312)
        Me.dgvDetallesTipoC.TabIndex = 0
        '
        'gbGenerarTipoCambio
        '
        Me.gbGenerarTipoCambio.BackColor = System.Drawing.Color.Transparent
        Me.gbGenerarTipoCambio.Controls.Add(Me.dtpFechacierre)
        Me.gbGenerarTipoCambio.Controls.Add(Me.Label2)
        Me.gbGenerarTipoCambio.Controls.Add(Me.txtTipoCompra)
        Me.gbGenerarTipoCambio.Controls.Add(Me.Label5)
        Me.gbGenerarTipoCambio.Controls.Add(Me.txtTipoVenta)
        Me.gbGenerarTipoCambio.Controls.Add(Me.Label4)
        Me.gbGenerarTipoCambio.Controls.Add(Me.dtpFecha)
        Me.gbGenerarTipoCambio.Controls.Add(Me.Label1)
        Me.gbGenerarTipoCambio.Controls.Add(Me.txtMoneda)
        Me.gbGenerarTipoCambio.Controls.Add(Me.Label3)
        Me.gbGenerarTipoCambio.Controls.Add(Me.TextBox1)
        Me.gbGenerarTipoCambio.Location = New System.Drawing.Point(14, 29)
        Me.gbGenerarTipoCambio.Name = "gbGenerarTipoCambio"
        Me.gbGenerarTipoCambio.Size = New System.Drawing.Size(377, 72)
        Me.gbGenerarTipoCambio.TabIndex = 164
        Me.gbGenerarTipoCambio.TabStop = False
        Me.gbGenerarTipoCambio.Visible = False
        '
        'dtpFechacierre
        '
        Me.dtpFechacierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpFechacierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechacierre.Location = New System.Drawing.Point(215, 46)
        Me.dtpFechacierre.Name = "dtpFechacierre"
        Me.dtpFechacierre.Size = New System.Drawing.Size(149, 20)
        Me.dtpFechacierre.TabIndex = 173
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Fecha a realizar cierre"
        '
        'txtTipoCompra
        '
        Me.txtTipoCompra.Location = New System.Drawing.Point(284, 94)
        Me.txtTipoCompra.Name = "txtTipoCompra"
        Me.txtTipoCompra.Size = New System.Drawing.Size(84, 20)
        Me.txtTipoCompra.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "Tipo de Compra"
        '
        'txtTipoVenta
        '
        Me.txtTipoVenta.Location = New System.Drawing.Point(194, 94)
        Me.txtTipoVenta.Name = "txtTipoVenta"
        Me.txtTipoVenta.Size = New System.Drawing.Size(84, 20)
        Me.txtTipoVenta.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Tipo de Venta"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "    MMMM  -  yyyy"
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(20, 46)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(149, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Mes y Año a cerrar"
        '
        'txtMoneda
        '
        Me.txtMoneda.Enabled = False
        Me.txtMoneda.Location = New System.Drawing.Point(22, 94)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(61, 20)
        Me.txtMoneda.TabIndex = 1
        Me.txtMoneda.Text = "ME"
        Me.txtMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Moneda"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(0, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 24)
        Me.TextBox1.TabIndex = 164
        Me.TextBox1.Text = "PROGRAMACION DE CIERRE DE VENTAS MENSUALES"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_cancelar, Me.btn_imprimir, Me.btn_salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(420, 25)
        Me.ToolStrip1.TabIndex = 171
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
        'btn_imprimir
        '
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(73, 22)
        Me.btn_imprimir.Text = "&Imprimir"
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(49, 22)
        Me.btn_salir.Text = "&Salir"
        '
        'FrmProCierreVentasMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 458)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbFiltroTipoCambio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbGenerarTipoCambio)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProCierreVentasMensual"
        Me.Text = "Prog. de Cierre de Ventas Mensual"
        Me.gbFiltroTipoCambio.ResumeLayout(False)
        Me.gbFiltroTipoCambio.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDetallesTipoC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGenerarTipoCambio.ResumeLayout(False)
        Me.gbGenerarTipoCambio.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbFiltroTipoCambio As System.Windows.Forms.GroupBox
    Friend WithEvents rbFechaMes As System.Windows.Forms.RadioButton
    Friend WithEvents rbFechaAnno As System.Windows.Forms.RadioButton
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaMes As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetallesTipoC As System.Windows.Forms.DataGridView
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
    Friend WithEvents dtpFechacierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
End Class
