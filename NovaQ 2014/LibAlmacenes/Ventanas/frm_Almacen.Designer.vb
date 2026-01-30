<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Almacen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Almacen))
        Me.bsAlmacen = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_grabar = New System.Windows.Forms.ToolStripButton()
        Me.btn_Editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtDescripcionTipoArticulo = New System.Windows.Forms.TextBox()
        Me.txtTipoArticulo = New System.Windows.Forms.TextBox()
        Me.txtUltimaSalida = New System.Windows.Forms.TextBox()
        Me.txtUltimoIngreso = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblTipoArticulo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDistrito = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvAlmacenes = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.tc_tipos = New System.Windows.Forms.TabControl()
        CType(Me.bsAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.tc_tipos.SuspendLayout()
        Me.SuspendLayout()
        '
        'bsAlmacen
        '
        Me.bsAlmacen.DataSource = GetType(LibAlmacenes.Almacen)
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
        Me.btn_grabar.Size = New System.Drawing.Size(66, 22)
        Me.btn_grabar.Text = "&Grabar"
        '
        'btn_Editar
        '
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(79, 22)
        Me.btn_Editar.Text = "&Modificar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(72, 22)
        Me.btn_eliminar.Text = "&Eliminar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 22)
        Me.btn_cancelar.Text = "&Cancelar"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton6.Text = "&Salir"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Nuevo, Me.btn_grabar, Me.btn_Editar, Me.btn_eliminar, Me.btn_cancelar, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(580, 25)
        Me.ToolStrip1.TabIndex = 53
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.txtDescripcionTipoArticulo)
        Me.TabPage2.Controls.Add(Me.txtTipoArticulo)
        Me.TabPage2.Controls.Add(Me.txtUltimaSalida)
        Me.TabPage2.Controls.Add(Me.txtUltimoIngreso)
        Me.TabPage2.Controls.Add(Me.txtTelefono)
        Me.TabPage2.Controls.Add(Me.txtDistrito)
        Me.TabPage2.Controls.Add(Me.txtDireccion)
        Me.TabPage2.Controls.Add(Me.txtDescripcion)
        Me.TabPage2.Controls.Add(Me.txtCodigo)
        Me.TabPage2.Controls.Add(Me.lblTipoArticulo)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.lblDistrito)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.cmbEstado)
        Me.TabPage2.ForeColor = System.Drawing.Color.Navy
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(546, 330)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso / Edición de Datos"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(218, 147)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox4.TabIndex = 110
        Me.PictureBox4.TabStop = False
        '
        'txtDescripcionTipoArticulo
        '
        Me.txtDescripcionTipoArticulo.BackColor = System.Drawing.Color.White
        Me.txtDescripcionTipoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionTipoArticulo.Location = New System.Drawing.Point(241, 146)
        Me.txtDescripcionTipoArticulo.Name = "txtDescripcionTipoArticulo"
        Me.txtDescripcionTipoArticulo.ReadOnly = True
        Me.txtDescripcionTipoArticulo.Size = New System.Drawing.Size(283, 20)
        Me.txtDescripcionTipoArticulo.TabIndex = 20
        '
        'txtTipoArticulo
        '
        Me.txtTipoArticulo.BackColor = System.Drawing.Color.Aquamarine
        Me.txtTipoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoArticulo.Location = New System.Drawing.Point(164, 146)
        Me.txtTipoArticulo.Name = "txtTipoArticulo"
        Me.txtTipoArticulo.Size = New System.Drawing.Size(50, 20)
        Me.txtTipoArticulo.TabIndex = 17
        '
        'txtUltimaSalida
        '
        Me.txtUltimaSalida.BackColor = System.Drawing.Color.White
        Me.txtUltimaSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUltimaSalida.Location = New System.Drawing.Point(25, 233)
        Me.txtUltimaSalida.Name = "txtUltimaSalida"
        Me.txtUltimaSalida.Size = New System.Drawing.Size(130, 20)
        Me.txtUltimaSalida.TabIndex = 6
        Me.txtUltimaSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUltimoIngreso
        '
        Me.txtUltimoIngreso.BackColor = System.Drawing.Color.White
        Me.txtUltimoIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUltimoIngreso.Location = New System.Drawing.Point(25, 186)
        Me.txtUltimoIngreso.Name = "txtUltimoIngreso"
        Me.txtUltimoIngreso.Size = New System.Drawing.Size(130, 20)
        Me.txtUltimoIngreso.TabIndex = 5
        Me.txtUltimoIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.White
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Location = New System.Drawing.Point(25, 147)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(129, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'txtDistrito
        '
        Me.txtDistrito.BackColor = System.Drawing.Color.White
        Me.txtDistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistrito.Location = New System.Drawing.Point(25, 108)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(499, 20)
        Me.txtDistrito.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(25, 69)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(499, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(96, 28)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(428, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(25, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'lblTipoArticulo
        '
        Me.lblTipoArticulo.AutoSize = True
        Me.lblTipoArticulo.Location = New System.Drawing.Point(224, 149)
        Me.lblTipoArticulo.Name = "lblTipoArticulo"
        Me.lblTipoArticulo.Size = New System.Drawing.Size(0, 13)
        Me.lblTipoArticulo.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(162, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Tipo de Artículo"
        '
        'lblDistrito
        '
        Me.lblDistrito.AutoSize = True
        Me.lblDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistrito.Location = New System.Drawing.Point(96, 111)
        Me.lblDistrito.Name = "lblDistrito"
        Me.lblDistrito.Size = New System.Drawing.Size(0, 13)
        Me.lblDistrito.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ult. Correlativo N. Salida"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ult. Correlativo N. Ingreso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Distrito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Código"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cmbEstado.Location = New System.Drawing.Point(25, 279)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(130, 21)
        Me.cmbEstado.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dgvAlmacenes)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.lblCantidad)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(546, 330)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Almacenes"
        '
        'dgvAlmacenes
        '
        Me.dgvAlmacenes.AllowUserToAddRows = False
        Me.dgvAlmacenes.AllowUserToDeleteRows = False
        Me.dgvAlmacenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlmacenes.Location = New System.Drawing.Point(6, 57)
        Me.dgvAlmacenes.Name = "dgvAlmacenes"
        Me.dgvAlmacenes.ReadOnly = True
        Me.dgvAlmacenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlmacenes.Size = New System.Drawing.Size(521, 246)
        Me.dgvAlmacenes.TabIndex = 126
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(521, 45)
        Me.GroupBox3.TabIndex = 125
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese texto a Buscar :"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.Aquamarine
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(7, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(508, 22)
        Me.txtFiltro.TabIndex = 24
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidad.ForeColor = System.Drawing.Color.Navy
        Me.lblCantidad.Location = New System.Drawing.Point(10, 306)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(11, 17)
        Me.lblCantidad.TabIndex = 124
        Me.lblCantidad.Text = "."
        '
        'tc_tipos
        '
        Me.tc_tipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tc_tipos.Controls.Add(Me.TabPage1)
        Me.tc_tipos.Controls.Add(Me.TabPage2)
        Me.tc_tipos.Location = New System.Drawing.Point(12, 31)
        Me.tc_tipos.Name = "tc_tipos"
        Me.tc_tipos.SelectedIndex = 0
        Me.tc_tipos.Size = New System.Drawing.Size(554, 356)
        Me.tc_tipos.TabIndex = 39
        '
        'frm_Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 399)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tc_tipos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Almacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacenes"
        CType(Me.bsAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tc_tipos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsAlmacen As System.Windows.Forms.BindingSource
    Friend WithEvents btn_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDescripcionTipoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtUltimaSalida As System.Windows.Forms.TextBox
    Friend WithEvents txtUltimoIngreso As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDistrito As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoArticulo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDistrito As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvAlmacenes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents tc_tipos As System.Windows.Forms.TabControl
End Class
