<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaStock))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_stock_cero = New System.Windows.Forms.CheckBox()
        Me.gbTodosAlmacenes = New System.Windows.Forms.GroupBox()
        Me.chkTodosAlmacenes = New System.Windows.Forms.CheckBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_tipo_origen = New System.Windows.Forms.ComboBox()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.gbdetalles = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvdetalles = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ImprimirPlanilla = New System.Windows.Forms.ToolStripButton()
        Me.btn_reporte_vida_util = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btn_stock_logistico = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbTodosAlmacenes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdetalles.SuspendLayout()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.lblCantidad)
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(734, 45)
        Me.GroupBox3.TabIndex = 121
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar :"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(403, 19)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 120
        Me.lblCantidad.Text = "."
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(13, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(384, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(23, 17)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(381, 24)
        Me.cboAlmacen.TabIndex = 122
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_stock_cero)
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Controls.Add(Me.gbTodosAlmacenes)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(964, 51)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Seleccione un Almacen"
        '
        'chk_stock_cero
        '
        Me.chk_stock_cero.AutoSize = True
        Me.chk_stock_cero.Location = New System.Drawing.Point(422, 21)
        Me.chk_stock_cero.Name = "chk_stock_cero"
        Me.chk_stock_cero.Size = New System.Drawing.Size(215, 17)
        Me.chk_stock_cero.TabIndex = 129
        Me.chk_stock_cero.Text = "Considerar productos con stock en cero"
        Me.chk_stock_cero.UseVisualStyleBackColor = True
        '
        'gbTodosAlmacenes
        '
        Me.gbTodosAlmacenes.Controls.Add(Me.chkTodosAlmacenes)
        Me.gbTodosAlmacenes.Controls.Add(Me.btnMostrar)
        Me.gbTodosAlmacenes.Location = New System.Drawing.Point(695, 7)
        Me.gbTodosAlmacenes.Name = "gbTodosAlmacenes"
        Me.gbTodosAlmacenes.Size = New System.Drawing.Size(242, 36)
        Me.gbTodosAlmacenes.TabIndex = 128
        Me.gbTodosAlmacenes.TabStop = False
        Me.gbTodosAlmacenes.Visible = False
        '
        'chkTodosAlmacenes
        '
        Me.chkTodosAlmacenes.AutoSize = True
        Me.chkTodosAlmacenes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodosAlmacenes.Location = New System.Drawing.Point(6, 12)
        Me.chkTodosAlmacenes.Name = "chkTodosAlmacenes"
        Me.chkTodosAlmacenes.Size = New System.Drawing.Size(144, 17)
        Me.chkTodosAlmacenes.TabIndex = 126
        Me.chkTodosAlmacenes.Text = "&Todos los Almacenes"
        Me.chkTodosAlmacenes.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chkTodosAlmacenes.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Enabled = False
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMostrar.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnMostrar.ForeColor = System.Drawing.Color.Blue
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostrar.Location = New System.Drawing.Point(154, 9)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(82, 23)
        Me.btnMostrar.TabIndex = 127
        Me.btnMostrar.Text = "&Consultar"
        Me.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbo_tipo_origen)
        Me.GroupBox2.Controls.Add(Me.dgvConsulta)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(10, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(966, 392)
        Me.GroupBox2.TabIndex = 125
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de articulos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(754, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Tipo Origen"
        '
        'cbo_tipo_origen
        '
        Me.cbo_tipo_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_origen.FormattingEnabled = True
        Me.cbo_tipo_origen.Location = New System.Drawing.Point(825, 30)
        Me.cbo_tipo_origen.Name = "cbo_tipo_origen"
        Me.cbo_tipo_origen.Size = New System.Drawing.Size(143, 21)
        Me.cbo_tipo_origen.TabIndex = 122
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AllowUserToAddRows = False
        Me.dgvConsulta.AllowUserToDeleteRows = False
        Me.dgvConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Location = New System.Drawing.Point(14, 64)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.ReadOnly = True
        Me.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsulta.Size = New System.Drawing.Size(935, 322)
        Me.dgvConsulta.TabIndex = 0
        '
        'gbdetalles
        '
        Me.gbdetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbdetalles.Controls.Add(Me.Label1)
        Me.gbdetalles.Controls.Add(Me.dgvdetalles)
        Me.gbdetalles.ForeColor = System.Drawing.Color.Navy
        Me.gbdetalles.Location = New System.Drawing.Point(11, 490)
        Me.gbdetalles.Name = "gbdetalles"
        Me.gbdetalles.Size = New System.Drawing.Size(965, 70)
        Me.gbdetalles.TabIndex = 126
        Me.gbdetalles.TabStop = False
        Me.gbdetalles.Text = "Detalles de Lotes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(18, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 17)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "."
        '
        'dgvdetalles
        '
        Me.dgvdetalles.AllowUserToAddRows = False
        Me.dgvdetalles.AllowUserToDeleteRows = False
        Me.dgvdetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles.Location = New System.Drawing.Point(14, 16)
        Me.dgvdetalles.Name = "dgvdetalles"
        Me.dgvdetalles.ReadOnly = True
        Me.dgvdetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdetalles.Size = New System.Drawing.Size(934, 43)
        Me.dgvdetalles.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ImprimirPlanilla, Me.btn_reporte_vida_util, Me.btn_stock_logistico, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(988, 25)
        Me.ToolStrip1.TabIndex = 181
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_ImprimirPlanilla
        '
        Me.btn_ImprimirPlanilla.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ImprimirPlanilla.ForeColor = System.Drawing.Color.Navy
        Me.btn_ImprimirPlanilla.Image = CType(resources.GetObject("btn_ImprimirPlanilla.Image"), System.Drawing.Image)
        Me.btn_ImprimirPlanilla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ImprimirPlanilla.Name = "btn_ImprimirPlanilla"
        Me.btn_ImprimirPlanilla.Size = New System.Drawing.Size(112, 22)
        Me.btn_ImprimirPlanilla.Text = "&Reportar Stock"
        '
        'btn_reporte_vida_util
        '
        Me.btn_reporte_vida_util.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_reporte_vida_util.Image = CType(resources.GetObject("btn_reporte_vida_util.Image"), System.Drawing.Image)
        Me.btn_reporte_vida_util.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_reporte_vida_util.Name = "btn_reporte_vida_util"
        Me.btn_reporte_vida_util.Size = New System.Drawing.Size(102, 22)
        Me.btn_reporte_vida_util.Text = "Rep. Vida Util"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton1.Text = "&Salir"
        '
        'btn_stock_logistico
        '
        Me.btn_stock_logistico.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_stock_logistico.Image = CType(resources.GetObject("btn_stock_logistico.Image"), System.Drawing.Image)
        Me.btn_stock_logistico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_stock_logistico.Name = "btn_stock_logistico"
        Me.btn_stock_logistico.Size = New System.Drawing.Size(164, 22)
        Me.btn_stock_logistico.Text = "Reportar Stock Logístico"
        '
        'FrmConsultaStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(988, 572)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbdetalles)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConsultaStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Stock"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbTodosAlmacenes.ResumeLayout(False)
        Me.gbTodosAlmacenes.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdetalles.ResumeLayout(False)
        Me.gbdetalles.PerformLayout()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents chkTodosAlmacenes As System.Windows.Forms.CheckBox
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents gbdetalles As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvdetalles As System.Windows.Forms.DataGridView
    Friend WithEvents gbTodosAlmacenes As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_ImprimirPlanilla As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk_stock_cero As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_origen As System.Windows.Forms.ComboBox
    Friend WithEvents btn_reporte_vida_util As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_stock_logistico As System.Windows.Forms.ToolStripButton
End Class
